using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditPayAccVchDetCommandValidator : AbstractValidator<EditPayAccVchDetCommand>
    {
        public EditPayAccVchDetCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
