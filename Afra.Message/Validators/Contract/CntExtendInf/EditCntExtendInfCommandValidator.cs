using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditCntExtendInfCommandValidator : AbstractValidator<EditCntExtendInfCommand>
    {
        public EditCntExtendInfCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
