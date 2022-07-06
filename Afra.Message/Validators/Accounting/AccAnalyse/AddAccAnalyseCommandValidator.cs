using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddAccAnalyseCommandValidator : AbstractValidator<AddAccAnalyseCommand>
    {
        public AddAccAnalyseCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
