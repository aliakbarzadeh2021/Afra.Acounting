using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddBdgTopicsRelsCommandValidator : AbstractValidator<AddBdgTopicsRelsCommand>
    {
        public AddBdgTopicsRelsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
