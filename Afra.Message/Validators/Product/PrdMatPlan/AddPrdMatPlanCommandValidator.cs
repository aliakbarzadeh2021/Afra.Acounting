using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddPrdMatPlanCommandValidator : AbstractValidator<AddPrdMatPlanCommand>
    {
        public AddPrdMatPlanCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
