using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddCmrInsuranceCommandValidator : AbstractValidator<AddCmrInsuranceCommand>
    {
        public AddCmrInsuranceCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
