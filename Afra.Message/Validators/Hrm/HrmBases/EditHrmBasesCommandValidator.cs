using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditHrmBasesCommandValidator : AbstractValidator<EditHrmBasesCommand>
    {
        public EditHrmBasesCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
