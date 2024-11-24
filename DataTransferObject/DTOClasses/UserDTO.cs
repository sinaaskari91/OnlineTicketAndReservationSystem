using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject.DTOClasses
{
    public class UserDTO:BaseDTO<Guid>
    {
        [Required(ErrorMessage ="درج نام الزامی است")]
        [DisplayName("نام")]
        public string FirstName { get; set; } = string.Empty;
        [Required(ErrorMessage = "درج نام خانوادگی الزامی است")]
        [DisplayName("نام خانوادگی")]
        public string LastName { get; set; } = string.Empty;
        [Required(ErrorMessage = "درج آدرس ایمیل الزامی است")]
        [DisplayName("آدرس ایمیل")]
        [EmailAddress(ErrorMessage ="فرمت آدرس ایمیل وارد شده نامعتبر است ")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "درج شماره موبایل الزامی است")]
        [Display(Name = "شماره موبایل")]
        public string MobileNumber { get; set; }
        [Required(ErrorMessage = "درج رمز عبور الزامی است")]
        [DisplayName("رمز عبور ")]
        [DataType(DataType.Password)]
        [StringLength(100,ErrorMessage ="رمز عبور حداقل باید 6 حرف باشد",MinimumLength =6)]

        public string Password { get; set; }= string.Empty;

        [Required(ErrorMessage = "تکرار رمز عبور الزامی است")]
        [DisplayName("تکرار رمز عبور ")]
        [DataType(DataType.Password)]
        [StringLength(100, ErrorMessage = "رمز عبور و تکرار آن باید یکی باشد", MinimumLength = 6)]
        public string ConfirmPassword { get; set; }=string.Empty;
        [Required(ErrorMessage = "درج تاریخ تولد الزامی است")]
        [DisplayName("تاریخ تولد")]
        public DateTime DateOfBirth { get; set; }
        //public virtual ICollection<RoleDTO> Roles { get; set; }
        // public virtual ICollection<TicketDTO> Tickets { get; set; }
        public BlobDTO? Avatar { get; set; }

    }
}
