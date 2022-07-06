using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddCmrReleaseCostCommandValidator : AbstractValidator<AddCmrReleaseCostCommand>
    {
        public AddCmrReleaseCostCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
