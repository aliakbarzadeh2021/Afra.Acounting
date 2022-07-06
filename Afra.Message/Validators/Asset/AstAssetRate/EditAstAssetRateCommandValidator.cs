using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditAstAssetRateCommandValidator : AbstractValidator<EditAstAssetRateCommand>
    {
        public EditAstAssetRateCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
