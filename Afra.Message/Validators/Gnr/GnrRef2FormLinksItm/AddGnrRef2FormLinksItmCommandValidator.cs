using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddGnrRef2FormLinksItmCommandValidator : AbstractValidator<AddGnrRef2FormLinksItmCommand>
    {
        public AddGnrRef2FormLinksItmCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
