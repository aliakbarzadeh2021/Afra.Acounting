using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddHrmStatMthdDetCommandValidator : AbstractValidator<AddHrmStatMthdDetCommand>
    {
        public AddHrmStatMthdDetCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
