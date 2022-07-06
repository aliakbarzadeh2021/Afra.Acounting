using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddUsrTrsRqstBankInfCommandValidator : AbstractValidator<AddUsrTrsRqstBankInfCommand>
    {
        public AddUsrTrsRqstBankInfCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
