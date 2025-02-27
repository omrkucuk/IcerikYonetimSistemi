using FluentValidation;
using IcerikUretimSistemi.Entites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcerikUretimSistemi.Business.Validators
{
    public class CommentsValidation:AbstractValidator<Comments>
    {
        public CommentsValidation()
        {
            RuleFor(c => c.Text).Length(1, 100).WithMessage("Lütfen yorum için en az 1 karakter kullanınız");
        }
    }
}
