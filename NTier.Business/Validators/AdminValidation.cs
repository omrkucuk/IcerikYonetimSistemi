using FluentValidation;
using IcerikUretimSistemi.Entites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcerikUretimSistemi.Business.Validators
{
    public class AdminValidation : AbstractValidator<Admin>
    {
        public AdminValidation()
        {
            RuleFor(a => a.AdminName).NotEmpty().WithMessage("Admin adı boş geçilemez");
            RuleFor(a => a.AdminPassword).NotEmpty().WithMessage("Parola kısmı boş bırakılamaz");
        }
    }
}
