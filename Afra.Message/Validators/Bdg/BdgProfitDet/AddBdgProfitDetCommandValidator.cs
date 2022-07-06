using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddBdgProfitDetCommandValidator : AbstractValidator<AddBdgProfitDetCommand>
    {
        public AddBdgProfitDetCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
