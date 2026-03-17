using System.ComponentModel.DataAnnotations;

namespace DemoMvc.Models.Entities
{
    public class Student1
    {
        [Required(ErrorMessage = "Vui lòng nhập mã sinh viên")]
        [StringLength(10, ErrorMessage = "Mã sinh viên không được vượt quá 10 ký tự")]
        public string Id { get; set; } = default!;

        [Required(ErrorMessage = "Vui lòng nhập tên")]
        [StringLength(100, ErrorMessage = "Tên không được vượt quá 100 ký tự")]
        public string Name { get; set; }   = default!;
        
        [Required(ErrorMessage = "Vui lòng nhập tuổi")]
        [Range(18, 100, ErrorMessage = "Tuổi phải từ 18 đến 100")]
        public int Age { get; set; } = default!;

        [Required(ErrorMessage = "Vui lòng nhập email")]
        [EmailAddress(ErrorMessage = "Vui lòng nhập đúng định dạng email")]
        public string Email { get; set; }   = default!;
    }
}

//  Required: Yêu cầu người dùng phải nhập giá trị cho thuộc tính này.
// StringLength: Giới hạn độ dài của chuỗi, với tham số đầu tiên là độ dài tối đa và tham số thứ hai là thông báo lỗi nếu vượt quá độ dài này.
// Range: Giới hạn giá trị của thuộc tính trong một khoảng nhất định, với tham số đầu tiên là giá trị tối thiểu và tham số thứ hai là giá trị tối đa, cùng với thông báo lỗi nếu giá trị không nằm trong khoảng này.
// EmailAddress: Kiểm tra xem giá trị có phải là một địa chỉ email hợp lệ hay không, với thông báo lỗi nếu giá trị không phải là một địa chỉ email hợp lệ.