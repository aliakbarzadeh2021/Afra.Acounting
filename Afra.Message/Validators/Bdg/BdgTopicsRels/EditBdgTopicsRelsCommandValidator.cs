using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditBdgTopicsRelsCommandValidator : AbstractValidator<EditBdgTopicsRelsCommand>
    {
        public EditBdgTopicsRelsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
