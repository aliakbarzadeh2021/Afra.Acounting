using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditPrdMatPkgCommandValidator : AbstractValidator<EditPrdMatPkgCommand>
    {
        public EditPrdMatPkgCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
