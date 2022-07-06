using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditTrsRcvBoredItmCommandValidator : AbstractValidator<EditTrsRcvBoredItmCommand>
    {
        public EditTrsRcvBoredItmCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
