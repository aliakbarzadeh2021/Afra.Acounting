using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddPmiReqPartCommandValidator : AbstractValidator<AddPmiReqPartCommand>
    {
        public AddPmiReqPartCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
