using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddCntAmntTypesCommandValidator : AbstractValidator<AddCntAmntTypesCommand>
    {
        public AddCntAmntTypesCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
