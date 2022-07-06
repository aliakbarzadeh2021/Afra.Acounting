using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditBdgAssetsDetCommandValidator : AbstractValidator<EditBdgAssetsDetCommand>
    {
        public EditBdgAssetsDetCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
