using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditHrmEmpTypesCommandValidator : AbstractValidator<EditHrmEmpTypesCommand>
    {
        public EditHrmEmpTypesCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
