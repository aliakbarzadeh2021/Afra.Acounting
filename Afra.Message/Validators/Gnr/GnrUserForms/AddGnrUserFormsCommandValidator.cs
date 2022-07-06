using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddGnrUserFormsCommandValidator : AbstractValidator<AddGnrUserFormsCommand>
    {
        public AddGnrUserFormsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
