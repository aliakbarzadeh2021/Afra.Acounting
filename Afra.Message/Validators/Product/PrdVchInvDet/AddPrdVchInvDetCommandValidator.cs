using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddPrdVchInvDetCommandValidator : AbstractValidator<AddPrdVchInvDetCommand>
    {
        public AddPrdVchInvDetCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
