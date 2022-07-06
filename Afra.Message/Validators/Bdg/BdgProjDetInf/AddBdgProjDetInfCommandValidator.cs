using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddBdgProjDetInfCommandValidator : AbstractValidator<AddBdgProjDetInfCommand>
    {
        public AddBdgProjDetInfCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
