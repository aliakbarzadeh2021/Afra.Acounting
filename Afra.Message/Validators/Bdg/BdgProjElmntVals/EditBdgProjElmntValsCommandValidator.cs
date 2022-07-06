using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditBdgProjElmntValsCommandValidator : AbstractValidator<EditBdgProjElmntValsCommand>
    {
        public EditBdgProjElmntValsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
