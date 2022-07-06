using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditTrsFContractDetCommandValidator : AbstractValidator<EditTrsFContractDetCommand>
    {
        public EditTrsFContractDetCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
