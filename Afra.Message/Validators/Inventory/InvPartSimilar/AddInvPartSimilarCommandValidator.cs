using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddInvPartSimilarCommandValidator : AbstractValidator<AddInvPartSimilarCommand>
    {
        public AddInvPartSimilarCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
