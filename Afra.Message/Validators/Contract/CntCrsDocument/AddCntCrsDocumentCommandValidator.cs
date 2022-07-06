using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddCntCrsDocumentCommandValidator : AbstractValidator<AddCntCrsDocumentCommand>
    {
        public AddCntCrsDocumentCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
