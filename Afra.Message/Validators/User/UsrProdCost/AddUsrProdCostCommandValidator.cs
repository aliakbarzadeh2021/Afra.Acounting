using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddUsrProdCostCommandValidator : AbstractValidator<AddUsrProdCostCommand>
    {
        public AddUsrProdCostCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
