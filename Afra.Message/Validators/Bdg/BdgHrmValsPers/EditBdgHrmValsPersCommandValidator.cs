using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditBdgHrmValsPersCommandValidator : AbstractValidator<EditBdgHrmValsPersCommand>
    {
        public EditBdgHrmValsPersCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
