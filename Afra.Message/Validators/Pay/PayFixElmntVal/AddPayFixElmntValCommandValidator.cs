using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddPayFixElmntValCommandValidator : AbstractValidator<AddPayFixElmntValCommand>
    {
        public AddPayFixElmntValCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
