using Entities.Concretes;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator() 
        {
        RuleFor(ct =>ct.Name).NotEmpty();
        RuleFor(ct =>ct.Name).MinimumLength(2);
        RuleFor(ct => ct.Name).Must(StartWithP).WithMessage("Kategori ismi P ile başlamalı");
        }

        public bool StartWithP(String arg)
        {
            return arg.StartsWith("P");
        }
    }
}
