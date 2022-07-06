using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditGnrRefFormsListDetCommandValidator : AbstractValidator<EditGnrRefFormsListDetCommand>
    {
        public EditGnrRefFormsListDetCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
