using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddAstAssetDeprCommandValidator : AbstractValidator<AddAstAssetDeprCommand>
    {
        public AddAstAssetDeprCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
