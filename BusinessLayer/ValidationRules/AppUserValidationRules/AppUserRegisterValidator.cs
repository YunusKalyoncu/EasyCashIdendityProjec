using DtoLayer.Dtos.AppUserDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules.AppUserValidationRules
{
    public class AppUserRegisterValidator:AbstractValidator<AppUserRegisterDto>
    {
        public AppUserRegisterValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad Alanı Boş Geçilemez.");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyadı Alanı Boş Geçilemez.");
            RuleFor(x => x.Username).NotEmpty().WithMessage("Kullanıcı Adı Alanı Boş Geçilemez.");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Mail Alanı Boş Geçilemez.");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre Alanı Boş Geçilemez.");
            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("Şifre tekrar Alanı Boş Geçilemez.");
            RuleFor(x => x.Name).MaximumLength(30).WithMessage("İsim Alanı en fazla 30 karakterden oluşabilir.");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("İsim Alanı en az 3 karakterden oluşabilir.");
            RuleFor(x => x.ConfirmPassword).Equal(y=>y.Password).WithMessage("Parolalarınız Eşleşmiyor.");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Lütfen geçerli bir mail adresi giriniz.");
            
        }
    }
}
