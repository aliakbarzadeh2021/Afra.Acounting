using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditUsrProdVchCommandValidator : AbstractValidator<EditUsrProdVchCommand>
    {
        public EditUsrProdVchCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
