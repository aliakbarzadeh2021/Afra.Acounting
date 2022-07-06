using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditGnrRef2FormLinkExpCommandValidator : AbstractValidator<EditGnrRef2FormLinkExpCommand>
    {
        public EditGnrRef2FormLinkExpCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
