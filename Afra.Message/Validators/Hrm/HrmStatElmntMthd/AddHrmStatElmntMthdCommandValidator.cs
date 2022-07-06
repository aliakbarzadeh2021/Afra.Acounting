using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddHrmStatElmntMthdCommandValidator : AbstractValidator<AddHrmStatElmntMthdCommand>
    {
        public AddHrmStatElmntMthdCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
