using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddGnrUserRefListDetCommandValidator : AbstractValidator<AddGnrUserRefListDetCommand>
    {
        public AddGnrUserRefListDetCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
