using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DevCard_MVC.Models
{
    public class Contact
    {
        [Required(ErrorMessage = "این فیلد اجباری می باشد")]
        [MaxLength(100 , ErrorMessage = "طول نام نباید بیشتر از 100 کاراکتر باشد .")]
        public string Name { get; set; }

        [Required(ErrorMessage = "این فیلد اجباری می باشد")]
        //[EmailAddress(ErrorMessage = "ایمیل وارد شده صحیح نمی باشد")]
        public string Email { get; set; }
        [Required(ErrorMessage = "این فیلد اجباری می باشد")]
        public string Service { get; set; }
        [Required(ErrorMessage = "این فیلد اجباری می باشد")]
        public string Message { get; set; }
    }
}
