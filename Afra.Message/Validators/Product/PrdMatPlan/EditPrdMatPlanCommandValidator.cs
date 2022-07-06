using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditPrdMatPlanCommandValidator : AbstractValidator<EditPrdMatPlanCommand>
    {
        public EditPrdMatPlanCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
