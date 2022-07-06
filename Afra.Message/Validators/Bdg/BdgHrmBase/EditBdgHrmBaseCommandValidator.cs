using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditBdgHrmBaseCommandValidator : AbstractValidator<EditBdgHrmBaseCommand>
    {
        public EditBdgHrmBaseCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
