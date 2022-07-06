using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditGnrDashboardsCommandValidator : AbstractValidator<EditGnrDashboardsCommand>
    {
        public EditGnrDashboardsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
