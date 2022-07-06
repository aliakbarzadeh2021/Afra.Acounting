using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddHrmEmpTypesCommandValidator : AbstractValidator<AddHrmEmpTypesCommand>
    {
        public AddHrmEmpTypesCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
