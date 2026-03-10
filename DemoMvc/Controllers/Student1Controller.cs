namespace DemoMvc.Controllers
{
    using DemoMvc.Data;
    using DemoMvc.Models.Entities;
    using Microsoft.AspNetCore.Mvc;
    // ApplicationDbContext context để truy cập vào database
    public class Student1Controller(ApplicationDbContext context) : Controller
    {
        private readonly ApplicationDbContext _context = context; // Khởi tạo biến _context để sử dụng trong các phương thức của controller
        [HttpGet]
        public IActionResult Index()
        {
            var listStudent = _context.Student1s.ToList();  // Lấy danh sách sinh viên từ database thông qua _context và lưu vào biến listStudent
            return View(listStudent);
        }
// Create
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student1 st)
        {
            _context.Student1s.Add(st); // Thêm đối tượng sinh viên mới vào database thông qua _context
            _context.SaveChanges(); // Lưu các thay đổi vào database
            return RedirectToAction("Index"); // Chuyển hướng về trang Index sau khi tạo thành công}
        }

// Edit
        public async Task<IActionResult> Edit(String Id)
        {
                var st = await _context.Student1s.FindAsync(Id); // Tìm kiếm sinh viên theo Id trong database thông qua _context
                if (st == null)
                {
                    return NotFound(); // Trả về lỗi 404 nếu không tìm thấy sinh viên
                }
            return View(st); // Trả về view Edit với đối tượng sinh viên được tìm thấy
        }
        [HttpPost]
        public IActionResult Edit(Student1 st)
        {   
            _context.Student1s.Update(st); // Cập nhật thông tin sinh viên trong database thông qua _context
            _context.SaveChanges(); // Lưu các thay đổi vào database
            return RedirectToAction("Index"); // Chuyển hướng về trang Index sau khi chỉnh sửa thành công
        }

// Delete
        public async Task<IActionResult> Delete(String Id)
        {
            var st = await _context.Student1s.FindAsync(Id); // Tìm kiếm sinh viên theo Id trong database thông qua _context
            if (st != null)
            {
                _context.Student1s.Remove(st); // Xóa sinh viên khỏi database
                await _context.SaveChangesAsync(); // Lưu thay đổi
            }
            return RedirectToAction("Index"); // Chuyển hướng về trang Index sau khi xóa
        }
            {
                _context.Student1s.Remove(st); // Xóa đối tượng sinh viên khỏi database thông qua _context
               await _context.SaveChangesAsync(); // Lưu các thay đổi vào database
            }
            return RedirectToAction("Index"); // Chuyển hướng về trang Index sau khi xóa thành công
        }
    }
}