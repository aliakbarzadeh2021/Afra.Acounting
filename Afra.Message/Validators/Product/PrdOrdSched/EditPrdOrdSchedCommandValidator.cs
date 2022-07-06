using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditPrdOrdSchedCommandValidator : AbstractValidator<EditPrdOrdSchedCommand>
    {
        public EditPrdOrdSchedCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
