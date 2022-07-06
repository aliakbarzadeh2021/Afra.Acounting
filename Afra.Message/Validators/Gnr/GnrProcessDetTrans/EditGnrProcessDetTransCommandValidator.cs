using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditGnrProcessDetTransCommandValidator : AbstractValidator<EditGnrProcessDetTransCommand>
    {
        public EditGnrProcessDetTransCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
