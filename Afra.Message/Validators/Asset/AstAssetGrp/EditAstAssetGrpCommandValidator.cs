using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditAstAssetGrpCommandValidator : AbstractValidator<EditAstAssetGrpCommand>
    {
        public EditAstAssetGrpCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
