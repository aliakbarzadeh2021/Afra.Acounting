using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddAstAssetRateCommandValidator : AbstractValidator<AddAstAssetRateCommand>
    {
        public AddAstAssetRateCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
