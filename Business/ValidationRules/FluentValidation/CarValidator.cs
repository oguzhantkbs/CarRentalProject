using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.CarName).NotEmpty();
            RuleFor(c => c.CarName).MinimumLength(2);
            RuleFor(c => c.Description).MaximumLength(200);
            
            RuleFor(c => c.CarName).Must(StartWithA).WithMessage("Araba isimleri A Harfi İle Başlamalı");//CustomValidation

        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }

      
    }
}
