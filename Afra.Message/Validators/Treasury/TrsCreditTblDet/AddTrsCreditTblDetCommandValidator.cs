using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddTrsCreditTblDetCommandValidator : AbstractValidator<AddTrsCreditTblDetCommand>
    {
        public AddTrsCreditTblDetCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
