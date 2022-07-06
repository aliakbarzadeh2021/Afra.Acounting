using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditTrsFacCrdTblDetCommandValidator : AbstractValidator<EditTrsFacCrdTblDetCommand>
    {
        public EditTrsFacCrdTblDetCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
