using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddBdgHrmValsPersCommandValidator : AbstractValidator<AddBdgHrmValsPersCommand>
    {
        public AddBdgHrmValsPersCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
