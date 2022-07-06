using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddUsrProdRcvCommandValidator : AbstractValidator<AddUsrProdRcvCommand>
    {
        public AddUsrProdRcvCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
