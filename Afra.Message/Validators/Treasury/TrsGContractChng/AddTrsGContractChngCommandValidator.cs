using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddTrsGContractChngCommandValidator : AbstractValidator<AddTrsGContractChngCommand>
    {
        public AddTrsGContractChngCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
