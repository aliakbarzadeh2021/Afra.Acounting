using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditHrmDeptJobRelCommandValidator : AbstractValidator<EditHrmDeptJobRelCommand>
    {
        public EditHrmDeptJobRelCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
