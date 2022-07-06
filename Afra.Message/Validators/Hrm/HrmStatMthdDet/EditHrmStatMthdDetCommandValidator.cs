using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditHrmStatMthdDetCommandValidator : AbstractValidator<EditHrmStatMthdDetCommand>
    {
        public EditHrmStatMthdDetCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
