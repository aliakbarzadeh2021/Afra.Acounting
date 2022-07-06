using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditAccDLCtgryRelCommandValidator : AbstractValidator<EditAccDLCtgryRelCommand>
    {
        public EditAccDLCtgryRelCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
