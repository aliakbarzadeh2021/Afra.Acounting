using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddHrmEmpStatueCommandValidator : AbstractValidator<AddHrmEmpStatueCommand>
    {
        public AddHrmEmpStatueCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
