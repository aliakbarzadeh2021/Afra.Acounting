using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddPayGrpValStatPersCommandValidator : AbstractValidator<AddPayGrpValStatPersCommand>
    {
        public AddPayGrpValStatPersCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
