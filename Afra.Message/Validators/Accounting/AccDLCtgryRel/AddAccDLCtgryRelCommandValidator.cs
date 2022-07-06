using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddAccDLCtgryRelCommandValidator : AbstractValidator<AddAccDLCtgryRelCommand>
    {
        public AddAccDLCtgryRelCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
