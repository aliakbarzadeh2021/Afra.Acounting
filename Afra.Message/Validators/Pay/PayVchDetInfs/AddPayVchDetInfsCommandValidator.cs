using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddPayVchDetInfsCommandValidator : AbstractValidator<AddPayVchDetInfsCommand>
    {
        public AddPayVchDetInfsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
