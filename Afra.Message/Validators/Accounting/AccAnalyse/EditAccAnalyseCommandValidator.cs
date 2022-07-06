using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditAccAnalyseCommandValidator : AbstractValidator<EditAccAnalyseCommand>
    {
        public EditAccAnalyseCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
