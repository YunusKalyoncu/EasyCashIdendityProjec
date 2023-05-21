﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLayer.Dtos.AppUserDtos
{
    public class AppUserRegisterDto
    {
        //[Required(ErrorMessage ="Ad Alanı Boş Bırakılamaz")]
        //[Display(Name="İsim:")]
        //[MaxLength(30,ErrorMessage ="En Fazla 30 karakterden oluşabilir.")]
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
    
}
