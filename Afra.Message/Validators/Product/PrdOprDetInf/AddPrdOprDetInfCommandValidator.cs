using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddPrdOprDetInfCommandValidator : AbstractValidator<AddPrdOprDetInfCommand>
    {
        public AddPrdOprDetInfCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
