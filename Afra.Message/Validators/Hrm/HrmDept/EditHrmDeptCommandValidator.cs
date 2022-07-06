using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditHrmDeptCommandValidator : AbstractValidator<EditHrmDeptCommand>
    {
        public EditHrmDeptCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
