using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddBdgProjectHrmCommandValidator : AbstractValidator<AddBdgProjectHrmCommand>
    {
        public AddBdgProjectHrmCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
