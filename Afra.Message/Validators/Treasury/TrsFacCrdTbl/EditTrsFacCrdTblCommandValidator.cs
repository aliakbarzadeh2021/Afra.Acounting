using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditTrsFacCrdTblCommandValidator : AbstractValidator<EditTrsFacCrdTblCommand>
    {
        public EditTrsFacCrdTblCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
