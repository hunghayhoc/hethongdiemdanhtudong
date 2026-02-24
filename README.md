# 🎓 Hệ Thống Nhận Diện & Điểm Danh Bằng Khuôn Mặt

> Ứng dụng AI tự động nhận diện khuôn mặt để điểm danh học sinh/sinh viên trong lớp học hoặc nhân viên trong doanh nghiệp — thay thế hoàn toàn phương pháp thủ công.

---

## 📌 Giới Thiệu

Dự án được xây dựng nhằm ứng dụng **Machine Learning vào phần mềm thực tế**, thể hiện khả năng kết hợp thị giác máy tính (Computer Vision), xử lý ảnh và giao diện người dùng trong một hệ thống hoàn chỉnh.

Hệ thống có thể:
- Nhận diện khuôn mặt theo thời gian thực qua webcam
- Tự động ghi nhận điểm danh vào cơ sở dữ liệu
- Quản lý danh sách học sinh / nhân viên
- Hỗ trợ ứng dụng trong game AI, NPC behavior và computer vision

---

## 🛠️ Công Nghệ Sử Dụng

| Thành phần | Công nghệ |
|---|---|
| Ngôn ngữ lập trình | C# (.NET Framework) |
| Xử lý ảnh | OpenCV thông qua EmguCV |
| Thuật toán AI | Haar Cascade Classifier + LBPH (Local Binary Patterns Histograms) |
| Cơ sở dữ liệu | SQL Server |
| Giao diện | Webcam API + LINQ |

---

## ✨ Tính Năng Chính

- 📷 **Nhận diện khuôn mặt theo thời gian thực** qua webcam
- 🤖 **Thuật toán LBPH** — nhận diện chính xác ngay cả khi ánh sáng thay đổi
- 🗃️ **Quản lý dữ liệu** — thêm, sửa, xoá học sinh / nhân viên
- 📊 **Lưu trữ điểm danh** vào SQL Server với timestamp
- 🖥️ **Giao diện thân thiện** — dễ sử dụng, hiển thị trực tiếp trên màn hình

---

## 🚀 Cài Đặt & Chạy Dự Án

### Yêu cầu hệ thống

- Visual Studio 2019 trở lên
- .NET Framework 4.7+
- SQL Server (LocalDB hoặc đầy đủ)
- Webcam

### Các bước cài đặt

```bash
# 1. Clone repository
git clone https://github.com/hunghayhoc/hethongdiemdanhtudong.git

# 2. Mở solution trong Visual Studio
# Mở file .sln

# 3. Cài đặt NuGet packages
# EmguCV, EntityFramework (tự động qua NuGet Restore)

# 4. Cấu hình chuỗi kết nối SQL Server trong App.config
# <connectionStrings>
#   <add name="..." connectionString="Data Source=...;Initial Catalog=DiemDanhDB;..." />
# </connectionStrings>

# 5. Chạy SQL script để tạo database (trong thư mục /Database)

# 6. Build & Run
```

---

## 📁 Cấu Trúc Dự Án

```
hethongdiemdanhtudong/
├── FaceRecognition/
│   ├── Forms/              # Giao diện người dùng
│   ├── Models/             # Các lớp dữ liệu
│   ├── Services/           # Logic nhận diện khuôn mặt
│   └── HaarCascade/        # File XML cho Haar Cascade
├── Database/
│   └── script.sql          # Script khởi tạo database
└── README.md
```

## 🧠 Thuật Toán

Dự án sử dụng **2 bước chính**:

1. **Haar Cascade Classifier** — phát hiện vị trí khuôn mặt trong khung hình
2. **LBPH (Local Binary Patterns Histograms)** — nhận diện danh tính từ khuôn mặt đã phát hiện

---

## 👨‍💻 Tác Giả

**Hưng Hay Học**
- GitHub: [@hunghayhoc](https://github.com/hunghayhoc)
