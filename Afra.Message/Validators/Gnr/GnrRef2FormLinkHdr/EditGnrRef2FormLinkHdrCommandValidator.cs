using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditGnrRef2FormLinkHdrCommandValidator : AbstractValidator<EditGnrRef2FormLinkHdrCommand>
    {
        public EditGnrRef2FormLinkHdrCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
