# Dreaw
Draw together. Dream together.
## Tính năng

- Vẽ chung thời gian thực.
- Đăng nhập/Đăng ký người dùng.
- Hỗ trợ nhiều phòng vẽ (Room).
- Chuyển đổi hình ảnh sang văn bản (OCR).

## Cách cài đặt

### Yêu cầu hệ thống:
- .NET Framework 4.8
- Python 3.12 (đúng phiên bản này)
- Microsoft SQL Server 2022
- Redis

# Hướng dẫn sử dụng dự án
### 1. Clone repository về máy
Sao chép repository từ GitHub về máy cục bộ:
```bash
git clone https://github.com/Hac1es/NT106-DoAn.git
cd NT106-DoAn
```

### 2. Cài đặt dependencies cho Python
Dự án sử dụng các thư viện Python được liệt kê trong tệp requirements.txt. Chạy lệnh sau để cài đặt:
```bash
pip install -r requirements.txt
```

### 3. Tạo cơ sở dữ liệu
Sử dụng nội dung trong tệp Database.txt và Microsoft SQL Server Management Studio (SSMS) để tạo cơ sở dữ liệu cần thiết.

### 4. Sửa địa chỉ server
Tìm trong CoreApp & DrawingForm dòng "https://b7d5-2402-800-6388-19ab-19cd-c82b-cd24-46af.ngrok-free.app" và sửa thành "https://localhost:7002" (nơi Load Balancer chạy)

### 5. Thứ tự khởi chạy dự án
#### Bật Redis
https://redis.io/blog/redis-on-windows-10/

#### Chạy tệp app.py trong thư mục **FlaskAPI** để khởi động server Flask:
```bash
python app.py
```
#### Sử dụng Visual Studio hoặc CLI để chạy phần C#. Mình sử dụng Visual Studio:
- Sử dụng Visual Studio để mở và chạy dự án.
- Đặt **Load Balancing** làm Startup Project.
- Mở bao nhiêu phiên bản debug của CoreApp tùy ý (chỉ chạy CoreApp, không chạy DrawingData).
#### Lưu ý: Do một số vấn đề liên quan đến SkiaSharp, không nên mở nhiều instance của CoreApp trong cùng một cửa sổ Visual Studio. Để kiểm tra tính năng vẽ chung, hãy mở nhiều cửa sổ Visual Studio hoặc thử nghiệm trên các máy khác nhau trong cùng mạng LAN.

### 5. Have Fun! 🎉
