using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditGnrDashFieldsCommandValidator : AbstractValidator<EditGnrDashFieldsCommand>
    {
        public EditGnrDashFieldsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
