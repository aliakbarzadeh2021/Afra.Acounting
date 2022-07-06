using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditCmrInsuranceCommandValidator : AbstractValidator<EditCmrInsuranceCommand>
    {
        public EditCmrInsuranceCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
