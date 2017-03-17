using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfService
{
    [DataContract]
    public class Client
    {
        [DataMember]
        public int Id { get; set; }


        [DataMember]
        [Required(ErrorMessage = "Поле должно быть установлено")]
        [StringLength(10, MinimumLength = 3, ErrorMessage = "Длина строки должна быть от 3 до 10 символов")]
        public string LoginName { get; set; }



        [DataMember]
        [Required(ErrorMessage = "Поле должно быть установлено")]
        [DataType(DataType.Password)]
        public string Password { get; set; }



        [Compare("Password", ErrorMessage = "Пароли не совпадают")]
        [DataType(DataType.Password)]
        public string PasswordConfirm { get; set; }



        [DataMember]
        [Required(ErrorMessage = "Поле должно быть установлено")]
        public string FirstName { get; set; }




        [Required(ErrorMessage = "Поле должно быть установлено")]
        [DataMember]
        public string LastName { get; set; }




        [Required(ErrorMessage = "Поле должно быть установлено")]
        [DataMember]
        public string PhoneNumber { get; set; }




        [Required(ErrorMessage = "Поле должно быть установлено")]
        [DataMember]
        public string Address { get; set; }






        public ICollection<Session> Sessions { get; set; }
        public Client()
        {
            Sessions = new List<Session>();
        }
    }
}