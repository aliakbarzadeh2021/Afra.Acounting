using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddGnrRef2FormLinkHdrCommandValidator : AbstractValidator<AddGnrRef2FormLinkHdrCommand>
    {
        public AddGnrRef2FormLinkHdrCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
