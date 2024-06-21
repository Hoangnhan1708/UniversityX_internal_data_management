import csv
import random

# Đường dẫn file CSV
output_file = 'donvi.csv'

# Danh sách các giá trị hợp lệ cho các trường có ràng buộc CHECK
madv_list = ['VPK', 'HTTT', 'CNPM', 'KHMT', 'CNTT', 'TGMT', 'MMT_VT']
tendv_list = [
    'Văn phòng khoa', 'Bộ môn Hệ thống thông tin', 'Bộ môn Công nghệ phần mềm', 
    'Bộ môn Khoa học thông tin', 'Bộ môn Công nghệ thông tin', 
    'Bộ môn Thị giác máy tính', 'Bộ môn Mạng máy tính và Viễn thông'
]

# Tạo dữ liệu giả cho các đơn vị
rows = []

for i in range(len(madv_list)):
    madv = madv_list[i]
    tendv = tendv_list[i]
    # Chọn ngẫu nhiên một mã nhân viên từ manv_list mà chưa được sử dụng làm TRGDV
    trgdv = None
    rows.append([madv, tendv, trgdv])

# Ghi dữ liệu vào file CSV
with open(output_file, mode='w', newline='', encoding='utf-8-sig') as file:
    writer = csv.writer(file)
    # Ghi tiêu đề cột
    writer.writerow(['MADV', 'TENDV', 'TRGDV'])
    # Ghi các dòng dữ liệu đơn vị
    writer.writerows(rows)

print(f'Dữ liệu giả đã được ghi vào {output_file}')
