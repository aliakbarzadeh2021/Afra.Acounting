using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddTrsFacCrdTblDetCommandValidator : AbstractValidator<AddTrsFacCrdTblDetCommand>
    {
        public AddTrsFacCrdTblDetCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
