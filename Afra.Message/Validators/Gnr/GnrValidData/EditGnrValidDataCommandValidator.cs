using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditGnrValidDataCommandValidator : AbstractValidator<EditGnrValidDataCommand>
    {
        public EditGnrValidDataCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
