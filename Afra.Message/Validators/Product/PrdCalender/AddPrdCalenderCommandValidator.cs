using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddPrdCalenderCommandValidator : AbstractValidator<AddPrdCalenderCommand>
    {
        public AddPrdCalenderCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
