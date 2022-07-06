using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditAstRatioDocsCommandValidator : AbstractValidator<EditAstRatioDocsCommand>
    {
        public EditAstRatioDocsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
