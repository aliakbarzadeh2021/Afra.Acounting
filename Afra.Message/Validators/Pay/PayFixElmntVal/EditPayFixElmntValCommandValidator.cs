using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditPayFixElmntValCommandValidator : AbstractValidator<EditPayFixElmntValCommand>
    {
        public EditPayFixElmntValCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
