﻿using Entities.Concretes;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class InstructorValidator :AbstractValidator<Instructor>
    {
        public InstructorValidator()
        {
            RuleFor(i => i.Name).NotEmpty();
            RuleFor(i => i.Name).MinimumLength(2);
            RuleFor(i => i.Name).MaximumLength(50);
        }

   
    }
}
