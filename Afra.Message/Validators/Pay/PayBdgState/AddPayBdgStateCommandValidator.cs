using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddPayBdgStateCommandValidator : AbstractValidator<AddPayBdgStateCommand>
    {
        public AddPayBdgStateCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
