using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditPrdOprDetPersCommandValidator : AbstractValidator<EditPrdOprDetPersCommand>
    {
        public EditPrdOprDetPersCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
