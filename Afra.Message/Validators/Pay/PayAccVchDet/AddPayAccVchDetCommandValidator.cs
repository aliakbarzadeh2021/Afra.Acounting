using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddPayAccVchDetCommandValidator : AbstractValidator<AddPayAccVchDetCommand>
    {
        public AddPayAccVchDetCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
