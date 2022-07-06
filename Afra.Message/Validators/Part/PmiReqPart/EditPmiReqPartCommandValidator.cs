using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditPmiReqPartCommandValidator : AbstractValidator<EditPmiReqPartCommand>
    {
        public EditPmiReqPartCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
