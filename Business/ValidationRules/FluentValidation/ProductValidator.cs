using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidator :AbstractValidator<Product>
    {
        public ProductValidator()//kurallar buraya yazılır.
        {
            RuleFor(p => p.ProductName).NotEmpty();
            RuleFor(p => p.ProductName).MinimumLength(2);
            RuleFor(p => p.UnitPrice).NotEmpty();
            RuleFor(p => p.UnitPrice).GreaterThan(0);
            RuleFor(p => p.UnitPrice).GreaterThanOrEqualTo(10).When(p => p.CategoryId == 1);//kategori 1 için 10birimden fazla
            //RuleFor(p => p.ProductName).Must(StartWithA).WithMessage("Products have to start with 'A'");
        }

        private bool StartWithA(string arg)//arg burada productname 
        {
            return arg.StartsWith("A");//true ya da false
        }
    }
}
