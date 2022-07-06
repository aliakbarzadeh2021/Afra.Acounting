using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditCmrSellerGrpCommandValidator : AbstractValidator<EditCmrSellerGrpCommand>
    {
        public EditCmrSellerGrpCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
