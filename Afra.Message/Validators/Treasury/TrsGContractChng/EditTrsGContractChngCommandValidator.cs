using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditTrsGContractChngCommandValidator : AbstractValidator<EditTrsGContractChngCommand>
    {
        public EditTrsGContractChngCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
