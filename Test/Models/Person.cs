using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Test.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "لطفا {0} را وارد کنید !")]
        [Display(Name = "نام کاربری")]
        public string UserName { get; set; }

        [Required]
        public string Email { get; set; }
        public int Age { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string PhoneNomber { get; set; }
    }
}
