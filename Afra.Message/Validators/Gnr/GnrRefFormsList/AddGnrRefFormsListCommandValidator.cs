using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddGnrRefFormsListCommandValidator : AbstractValidator<AddGnrRefFormsListCommand>
    {
        public AddGnrRefFormsListCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
