using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditBdgProjDetInfCommandValidator : AbstractValidator<EditBdgProjDetInfCommand>
    {
        public EditBdgProjDetInfCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
