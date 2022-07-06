using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddBdgAssetsDetCommandValidator : AbstractValidator<AddBdgAssetsDetCommand>
    {
        public AddBdgAssetsDetCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
