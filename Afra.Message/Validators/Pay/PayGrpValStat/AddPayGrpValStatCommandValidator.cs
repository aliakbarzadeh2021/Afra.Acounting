using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddPayGrpValStatCommandValidator : AbstractValidator<AddPayGrpValStatCommand>
    {
        public AddPayGrpValStatCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
