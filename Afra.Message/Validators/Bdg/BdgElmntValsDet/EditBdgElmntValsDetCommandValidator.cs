using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditBdgElmntValsDetCommandValidator : AbstractValidator<EditBdgElmntValsDetCommand>
    {
        public EditBdgElmntValsDetCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
