using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddHrmEmpStatAmntCommandValidator : AbstractValidator<AddHrmEmpStatAmntCommand>
    {
        public AddHrmEmpStatAmntCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
