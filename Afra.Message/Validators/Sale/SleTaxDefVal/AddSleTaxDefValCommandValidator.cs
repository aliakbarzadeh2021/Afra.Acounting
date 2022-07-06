using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddSleTaxDefValCommandValidator : AbstractValidator<AddSleTaxDefValCommand>
    {
        public AddSleTaxDefValCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
