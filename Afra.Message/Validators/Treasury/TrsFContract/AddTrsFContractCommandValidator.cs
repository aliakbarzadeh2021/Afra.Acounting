using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddTrsFContractCommandValidator : AbstractValidator<AddTrsFContractCommand>
    {
        public AddTrsFContractCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
