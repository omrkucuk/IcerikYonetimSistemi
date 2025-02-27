using FluentValidation;
using IcerikUretimSistemi.Entites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcerikUretimSistemi.Business.Validators
{
    public class PostValidation : AbstractValidator<Posts>
    {
        public PostValidation()
        {
            RuleFor(p => p.Title).NotEmpty().WithMessage("Post başlığı boş geçilemez");
        }
    }
}
