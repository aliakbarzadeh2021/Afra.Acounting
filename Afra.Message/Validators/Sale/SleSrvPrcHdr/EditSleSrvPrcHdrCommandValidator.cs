using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditSleSrvPrcHdrCommandValidator : AbstractValidator<EditSleSrvPrcHdrCommand>
    {
        public EditSleSrvPrcHdrCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
