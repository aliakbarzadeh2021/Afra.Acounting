using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditPrdOprDetInfCommandValidator : AbstractValidator<EditPrdOprDetInfCommand>
    {
        public EditPrdOprDetInfCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
