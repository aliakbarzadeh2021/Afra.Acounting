using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditBdgHrmValsDetCommandValidator : AbstractValidator<EditBdgHrmValsDetCommand>
    {
        public EditBdgHrmValsDetCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
