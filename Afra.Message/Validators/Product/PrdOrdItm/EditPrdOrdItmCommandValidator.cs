using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditPrdOrdItmCommandValidator : AbstractValidator<EditPrdOrdItmCommand>
    {
        public EditPrdOrdItmCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
