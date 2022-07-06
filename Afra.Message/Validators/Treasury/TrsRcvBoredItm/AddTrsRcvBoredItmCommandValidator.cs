using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddTrsRcvBoredItmCommandValidator : AbstractValidator<AddTrsRcvBoredItmCommand>
    {
        public AddTrsRcvBoredItmCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
