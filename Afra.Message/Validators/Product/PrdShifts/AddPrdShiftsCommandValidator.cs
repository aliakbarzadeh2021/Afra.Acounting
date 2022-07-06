using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddPrdShiftsCommandValidator : AbstractValidator<AddPrdShiftsCommand>
    {
        public AddPrdShiftsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
