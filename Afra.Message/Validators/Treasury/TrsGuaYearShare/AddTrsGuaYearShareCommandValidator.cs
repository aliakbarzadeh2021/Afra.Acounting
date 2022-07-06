using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddTrsGuaYearShareCommandValidator : AbstractValidator<AddTrsGuaYearShareCommand>
    {
        public AddTrsGuaYearShareCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
