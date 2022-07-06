using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditPayFixElmntCommandValidator : AbstractValidator<EditPayFixElmntCommand>
    {
        public EditPayFixElmntCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
