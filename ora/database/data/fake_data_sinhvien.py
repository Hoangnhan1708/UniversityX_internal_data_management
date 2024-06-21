import csv
import random
import faker
from datetime import datetime

# Sử dụng thư viện faker để tạo dữ liệu giả
fake = faker.Faker()

# Đường dẫn file CSV
output_file = 'sinhvien.csv'

# Danh sách các giá trị hợp lệ cho các trường có ràng buộc CHECK
genders = ['Nam', 'Nữ']
programs = ['CQ', 'CLC', 'CTTT', 'VP']


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

def generate_phone_number():
    # Chọn một số điện thoại ngẫu nhiên
    first_digit = '0'  # Bắt đầu với số 0
    second_digit = str(random.randint(3, 9))  # Số thứ hai có thể là từ 3 đến 9
    remaining_digits = ''.join(random.choices('0123456789', k=8))  # 8 số cuối cùng có thể là bất kỳ số nào từ 0 đến 9
    phone_number = f"{first_digit}{second_digit}{remaining_digits}"
    return phone_number


provinces = [
    'An Giang', 'Bà Rịa - Vũng Tàu', 'Bạc Liêu', 'Bắc Kạn', 'Bắc Giang', 'Bắc Ninh', 'Bến Tre',
    'Bình Định', 'Bình Dương', 'Bình Phước', 'Bình Thuận', 'Cà Mau', 'Cao Bằng', 'Cần Thơ',
    'Đà Nẵng', 'Đắk Lắk', 'Đắk Nông', 'Điện Biên', 'Đồng Nai', 'Đồng Tháp', 'Gia Lai',
    'Hà Giang', 'Hà Nam', 'Hà Nội', 'Hà Tĩnh', 'Hải Dương', 'Hải Phòng', 'Hậu Giang',
    'Hòa Bình', 'Hưng Yên', 'Khánh Hòa', 'Kiên Giang', 'Kon Tum', 'Lai Châu', 'Lâm Đồng',
    'Lạng Sơn', 'Lào Cai', 'Long An', 'Nam Định', 'Nghệ An', 'Ninh Bình', 'Ninh Thuận',
    'Phú Thọ', 'Phú Yên', 'Quảng Bình', 'Quảng Nam', 'Quảng Ngãi', 'Quảng Ninh', 'Quảng Trị',
    'Sóc Trăng', 'Sơn La', 'Tây Ninh', 'Thái Bình', 'Thái Nguyên', 'Thanh Hóa', 'Thừa Thiên Huế',
    'Tiền Giang', 'TP. Hồ Chí Minh', 'Trà Vinh', 'Tuyên Quang', 'Vĩnh Long', 'Vĩnh Phúc', 'Yên Bái'
]





# Tạo dữ liệu giả cho 4000 sinh viên
rows = []
for i in range(4000):
    masv = f'SV{i+1:04d}'  # Tạo mã sinh viên dạng SV0001, SV0002, ..., SV4000
    hoten = generate_random_name()
    phai = random.choice(genders)
    ngsinh = fake.date_of_birth(minimum_age=18, maximum_age=25).strftime('%Y-%m-%d')
    dchi = random.choice(provinces)
    dt = generate_phone_number()
    mact = random.choice(programs)
    manganh = f'CNTT' 
    sotctl = None  # Số tín chỉ tích lũy luôn NULL
    dtbtl = None  # Điểm trung bình tích lũy luôn NULL

    rows.append([masv, hoten, phai, ngsinh, dchi, dt, mact, manganh, sotctl, dtbtl])

# Ghi dữ liệu vào file CSV
with open(output_file, mode='w', newline='', encoding='utf-8-sig') as file:
    writer = csv.writer(file)
    # Ghi tiêu đề cột
    writer.writerow(['MASV', 'HOTEN', 'PHAI', 'NGSINH', 'DCHI', 'DT', 'MACT', 'MANGANH', 'SOTCTL', 'DTBTL'])
    # Ghi các dòng dữ liệu sinh viên
    writer.writerows(rows)

print(f'Dữ liệu giả đã được ghi vào {output_file}')
