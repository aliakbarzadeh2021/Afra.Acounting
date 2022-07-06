using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddAstAssetCtgryCommandValidator : AbstractValidator<AddAstAssetCtgryCommand>
    {
        public AddAstAssetCtgryCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
