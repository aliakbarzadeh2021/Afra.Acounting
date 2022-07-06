using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditUsrTrsRqstBankInfCommandValidator : AbstractValidator<EditUsrTrsRqstBankInfCommand>
    {
        public EditUsrTrsRqstBankInfCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
