using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddGnrRef2FormLinkExpCommandValidator : AbstractValidator<AddGnrRef2FormLinkExpCommand>
    {
        public AddGnrRef2FormLinkExpCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
