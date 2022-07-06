using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditPayGrpValStatCommandValidator : AbstractValidator<EditPayGrpValStatCommand>
    {
        public EditPayGrpValStatCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
