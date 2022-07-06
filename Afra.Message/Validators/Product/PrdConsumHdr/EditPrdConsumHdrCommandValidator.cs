using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditPrdConsumHdrCommandValidator : AbstractValidator<EditPrdConsumHdrCommand>
    {
        public EditPrdConsumHdrCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
