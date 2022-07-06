using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditCntCrsDocumentCommandValidator : AbstractValidator<EditCntCrsDocumentCommand>
    {
        public EditCntCrsDocumentCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
