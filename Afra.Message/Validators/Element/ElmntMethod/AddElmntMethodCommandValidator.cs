using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddElmntMethodCommandValidator : AbstractValidator<AddElmntMethodCommand>
    {
        public AddElmntMethodCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
