using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddPrdOprDetCommandValidator : AbstractValidator<AddPrdOprDetCommand>
    {
        public AddPrdOprDetCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
