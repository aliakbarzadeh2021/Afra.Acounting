using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditTrsPayChqItmCommandValidator : AbstractValidator<EditTrsPayChqItmCommand>
    {
        public EditTrsPayChqItmCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
