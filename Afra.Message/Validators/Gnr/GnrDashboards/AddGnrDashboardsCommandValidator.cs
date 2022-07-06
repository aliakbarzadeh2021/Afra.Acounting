using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddGnrDashboardsCommandValidator : AbstractValidator<AddGnrDashboardsCommand>
    {
        public AddGnrDashboardsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
