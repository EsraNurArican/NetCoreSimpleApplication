using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IntroNetCoreCont.Models
{
    public class UserResponse
    {
        //validation işlemleri 
        [Required(ErrorMessage = "Lütfen adınızı giriniz....")]
        [MinLength(2, ErrorMessage = "En az iki harf giriniz")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Lütfen e-posta adresinizi giriniz...")]
        [EmailAddress(ErrorMessage = "E-posta formatı doğru değil!!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Lütfen katılım durumunu seçiniz...")]
        // ? koyarak boş geçilebilir bıraktabilirdik
        public bool IsAccepted { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
