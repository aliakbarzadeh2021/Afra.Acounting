using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditBdgBalanceValsDetCommandValidator : AbstractValidator<EditBdgBalanceValsDetCommand>
    {
        public EditBdgBalanceValsDetCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
