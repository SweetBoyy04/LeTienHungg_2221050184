# 1, Mô hình MVC

    Model - View - Controller
        - Model : quản lý dữ liệu và nghiệp vụ ( chứa các class dữ liệu , đại diện cho bảng trong database)
        - View : hiển thị giao diện người dùng ( mỗi controller có 1 thư mục View tương ứng , và chứa các ?.cshtml 'trong ?.cshtml sẽ chứa các Action tương ứng với Action đã khai báo ở Controller')
        - Controller : nhận request từ người dùng , xử lý logic và trả dữ liệu cho View
    Luồng hoạt động :
        Người dùng gửi req -> Controller nhận req -> Controller gọi Model xử lý dữ liệu -> Controller trả dữ liệu cho View -> View hiển thị kết quả ra màn hình trình duyệt

# 2, Định tuyến Route

    Khái niệm : là cơ chế xác định đường dẫn URL gọi đến Controller và Action
    URL  →  Controller  →  Action  →  View
        VDU: https://localhost:5001/Home/Index
           - Khi người dùng truy cập URl thì hệ thống : nó sẽ hiểu là
                 Controller = HomeController và Action = Index()
           - Thực thi : HomeController.Index()
           - Trả về  : Views/Home/Index.cshtml
         * pattern: "{controller=Home}/{action=Index}/{id?}"
            - Nếu Không có Controller, action nào , thì mặc định là home và index ( lưu ý đúng theo thứ tự á controller trc rồi mới tới action)
            - Tạo controller mới xong nhớ tạo thư mục cùng tên ở trong View để chỉ tới , trong thư mục mới đó nhớ tạo thêm tên Action trùng với Action đã khai báo ở trong bài

# 3, Khái niệm Namespace

    Nói đơn giản Namspace = hộp chứa đựng class
        - Là không gian tên để chứa các nhóm class liên quan , tránh trùng tên  , tổ chức project cho dễ quản lý

# 4, Controller and View

    I, Controller : Là thành phần xử lý yêu cầu từ người dùng
        - Nhận req từ người dùng
        - Xử lý logic
        - Gọi Model ( nếu có )
        - Quy định trả về View hay data
    II , View : là giao diện người dùng
        - Không xử lý logic nghiệp vụ
        - Chỉ hiển thị dữ liệu
    III , Mối quan hệ giữ View và Controller
           URL  →  Controller  →  Action  →  View
           ( Đã giải thích ở trên)

# 5 , Viewbag

    Được dùng để truyền dữ liệu từ controller sang View trong ASP.Net.MVC . Dữ liệu được gán trong Controller và truy cập trực tiếp trong View thông qua @Viewbag.tenbien
    * Lưu ý :
        ViewBag không có kiểu dữ liệu cố định
        Chỉ dùng 1 request
        Viết sai tên -> null, không báo lỗi compile

# 6 , Kết Nối DataBase
    Cài đặt tool hỗ trợ quản lý phiên bản CSDL (Migrations), tool hỗ trợ sinh mã nguồn
    Cài đặt các package (các gói hỗ trợ để kết nối và làm việc với cơ sở dữ liệu)
    Link : https://learn.microsoft.com/vi-vn/aspnet/core/tutorials/first-mvc-app/adding-model?view=aspnetcore-6.0&tabs=visual-studio-code
    Tạo file Data/ApplicationDBContext.cs
    Cấu hình ở file appsettings.json
    Cấu hình ở file Program.cs
    Vdu:
        dotnet ef migrations add Create_Table_Students
        dotnet ef database update

