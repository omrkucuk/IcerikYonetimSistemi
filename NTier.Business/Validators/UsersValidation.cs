using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using IcerikUretimSistemi.Entites.Models;

namespace IcerikUretimSistemi.Business.Validators
{
    public class UsersValidation : AbstractValidator<User>
    {
        public UsersValidation() 
        {
            RuleFor(u => u.UserName).NotEmpty().WithMessage("Kullanıcı adı boş bırakılamaz");
            RuleFor(u => u.Password).NotEmpty().WithMessage("Şifre kısmı boş bırakılamaz").Length(7,25).WithMessage("Şifre en az 8 karakter içermelidir");
        }
    }
}
