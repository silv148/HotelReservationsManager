﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelReservationsManagement.ViewModels.Users
{
    public class CreateVM
    {
        [DisplayName("Потребителско име: ")]
        [Required(ErrorMessage = "*Това поле е задължително!")]
        public string Username { get; set; }

        [DisplayName("Парола: ")]
        [Required(ErrorMessage = "*Това поле е задължително!")]
        public string Password { get; set; }

        [DisplayName("Име: ")]
        [Required(ErrorMessage = "*Това поле е задължително!")]
        public string FirstName { get; set; }

        [DisplayName("Презиме: ")]
        [Required(ErrorMessage = "*Това поле е задължително!")]
        public string Surname { get; set; }

        [DisplayName("Фамилия: ")]
        [Required(ErrorMessage = "*Това поле е задължително!")]
        public string LastName { get; set; }

        [DisplayName("ЕГН: ")]
        [Required(ErrorMessage = "*Това поле е задължително!")]
        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "ЕГН трябва да бъде съставено от 10 цифри!")]
        public string EGN { get; set; }

        [DisplayName("Телефонен номер: ")]
        [Required(ErrorMessage = "*Това поле е задължително!")]
        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Невалиден телефонен номер!")]
        public string PhoneNumber { get; set; }

        [DisplayName("Е-мейл: ")]
        [Required(ErrorMessage = "*Това поле е задължително!")]
        public string Email { get; set; }

        [DisplayName("Дата на назначаване: ")]
        [Required(ErrorMessage = "*Това поле е задължително!")]
        public DateTime DateOfAppointment { get; set; }

        [DisplayName("   Активен")]
        [Required(ErrorMessage = "*Това поле е задължително!")]
        public bool IsActive { get; set; }
    }
}
