using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditPayGrpValStatAmntCommandValidator : AbstractValidator<EditPayGrpValStatAmntCommand>
    {
        public EditPayGrpValStatAmntCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
