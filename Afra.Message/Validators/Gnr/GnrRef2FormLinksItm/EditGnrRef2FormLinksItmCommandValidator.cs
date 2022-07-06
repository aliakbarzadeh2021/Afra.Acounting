using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditGnrRef2FormLinksItmCommandValidator : AbstractValidator<EditGnrRef2FormLinksItmCommand>
    {
        public EditGnrRef2FormLinksItmCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
