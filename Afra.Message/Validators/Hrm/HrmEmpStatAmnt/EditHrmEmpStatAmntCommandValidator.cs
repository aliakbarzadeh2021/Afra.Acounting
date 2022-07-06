using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditHrmEmpStatAmntCommandValidator : AbstractValidator<EditHrmEmpStatAmntCommand>
    {
        public EditHrmEmpStatAmntCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
