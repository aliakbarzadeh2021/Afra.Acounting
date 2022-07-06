using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddBdgHrmBaseCommandValidator : AbstractValidator<AddBdgHrmBaseCommand>
    {
        public AddBdgHrmBaseCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
