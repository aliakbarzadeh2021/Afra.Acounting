using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditPrdOprDetCommandValidator : AbstractValidator<EditPrdOprDetCommand>
    {
        public EditPrdOprDetCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
