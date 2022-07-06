using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddGnrSysFormsCommandValidator : AbstractValidator<AddGnrSysFormsCommand>
    {
        public AddGnrSysFormsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
