using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Shop.Data.Models
{
    public class Order {

        [BindNever]
        public int id { get; set; }

        [Display(Name = "Введите имя")]
        [StringLength(10)]
        [Required(ErrorMessage = "Длина имени не менее 10 символов")]
        public string name { get; set; }

        [Display(Name = "Фамилия")]
        [StringLength(10)]
        [Required(ErrorMessage = "Длина фамилии не менее 10 символов")]
        public string surname { get; set; }

        [Display(Name = "Адрес")]
        [StringLength(15)]
        [Required(ErrorMessage = "Длина адреса не менее 15 символов")]
        public string address { get; set; }

        [Display(Name = "Номер телефона")]
        [StringLength(15)]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Длина номера телефона не менее 15 символов")]
        public string phone{ get; set; }

        [Display(Name = "Email")]
        [StringLength(15)]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Длина email не менее 15 символов")]
        public string email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime orderTime { get; set; }

        public List<OrderDetail> orderDetails { get; set; }
    }
}
