import csv
import random
from faker import Faker

# Thiết lập Faker
fake = Faker('vi_VN')

# Cấu hình số lượng vai trò
roles = {
    "Trưởng khoa": 1,
    "Trưởng đơn vị": 6,
    
    "Giáo vụ": 10,
    "Nhân viên cơ bản": 10,
    "Giảng viên": 80
}

# Danh sách các vai trò theo thứ tự ưu tiên
roles_list = [role for role, count in roles.items() for _ in range(count)]

# Danh sách các họ
ho = ['Nguyễn', 'Trần', 'Lê', 'Hoàng', 'Phạm', 'Hoàng', 'Huỳnh', 'Võ', 'Đặng', 'Bùi', 'Đỗ']

# Danh sách các tên lót
ten_lot = ['Thị', 'Văn', 'Minh', 'Thành', 'Như', 'Đức', 'Phương', 'Huy', 'Tú', 'Hồng', 
           'Thị Kim', 'Văn Huy', 'Minh Hà', 'Thành Đức', 'Đức Long', 'Phương Anh', 
           'Huy Tú', 'Tú Quân', 'Hào Nam', 'Quốc Việt']

# Danh sách các tên
ten = ['Quỳnh', 'Nam', 'Mai', 'Hoàng', 'Trúc', 'Đức', 'Lan', 'Dương', 'Ngân', 'Tân', 'Thùy', 
       'Minh', 'Phong', 'Linh', 'Khánh', 'Thắng', 'Hương', 'Hòa', 'Hải', 'Tâm', 'Thanh', 
       'Anh', 'Thảo', 'Đức', 'Thúy', 'Bảo', 'Ngọc', 'Tuấn', 'Tú', 'Trang', 'Phúc', 'Hưng', 
       'Quang', 'Hà', 'Thắng', 'Đạt', 'Thúy', 'Phượng', 'Điền', 'Trường', 'Duy', 'Diệu', 
       'Bình', 'Phương', 'Hiếu', 'Nguyệt', 'Khải', 'Thành', 'Hồng', 'Thắm']

def generate_random_name():
    # Chọn một họ ngẫu nhiên
    ho_chosen = random.choice(ho)
    
    # Chọn một tên lót ngẫu nhiên
    ten_lot_chosen = random.choice(ten_lot)
    
    # Chọn một tên ngẫu nhiên
    ten_chosen = random.choice(ten)
    
    # Kết hợp các phần để tạo tên đầy đủ
    full_name = f"{ho_chosen} {ten_lot_chosen} {ten_chosen}"
    
    return full_name

def generate_manv():
    # Tạo mã nhân viên với chữ "NS" ở trước và số ngẫu nhiên sau đó
    manv = f"NV{generate_manv.counter:04d}"
    # Tăng biến đếm lên mỗi lần hàm được gọi
    generate_manv.counter += 1
    return manv

# Khởi tạo biến đếm
generate_manv.counter = 1

def generate_phone_number():
    # Chọn một số điện thoại ngẫu nhiên
    first_digit = '0'  # Bắt đầu với số 0
    second_digit = str(random.randint(3, 9))  # Số thứ hai có thể là từ 3 đến 9
    remaining_digits = ''.join(random.choices('0123456789', k=8))  # 8 số cuối cùng có thể là bất kỳ số nào từ 0 đến 9
    phone_number = f"{first_digit}{second_digit}{remaining_digits}"
    return phone_number

# Hàm tạo mã đơn vị
def generate_unique_madv(existing_madv):
    # Tạo số ngẫu nhiên từ 1 đến 7 cho 7 đơn vị
    while True:
        formatted_number = random.choice(madv_list)
        if formatted_number not in existing_madv:
            existing_madv.add(formatted_number)
            return formatted_number
        
madv_list = ['VPK', 'HTTT', 'CNPM', 'KHMT', 'CNTT', 'TGMT', 'MMT_VT']

# Hàm tạo dữ liệu
def generate_nhansu_data(num_records):
    data = []
    existing_madv = set()
    for i in range(num_records):
        manv = generate_manv()
        hoten = generate_random_name()
        phai = random.choice(['Nam', 'Nữ'])
        ngsinh = fake.date_of_birth(minimum_age=22, maximum_age=60).strftime('%Y-%m-%d')
        phucap = random.randint(0, 40) * 50000
        dt = generate_phone_number()
        vaitro = roles_list[i]
        if vaitro in ["Trưởng khoa", "Trưởng đơn vị"]:
            madv = generate_unique_madv(existing_madv)
        else:
            madv = random.choice(madv_list)
        data.append([manv, hoten, phai, ngsinh, phucap, dt, vaitro, madv])
    return data

# Tạo dữ liệu
nhansu_data = generate_nhansu_data(len(roles_list))

# Sắp xếp dữ liệu theo vai trò từ cao đến thấp
role_priority = {role: index for index, role in enumerate(roles.keys())}
nhansu_data.sort(key=lambda x: role_priority[x[6]])

# Lưu dữ liệu vào file CSV với encoding UTF-8
with open('nhansu.csv', mode='w', newline='', encoding='utf-8-sig') as file:  # Sử dụng utf-8-sig để đảm bảo không có byte order mark (BOM)
    writer = csv.writer(file)
    writer.writerow(['MANV', 'HOTEN', 'PHAI', 'NGSINH', 'PHUCAP', 'DT', 'VAITRO', 'MADV'])
    writer.writerows(nhansu_data)
