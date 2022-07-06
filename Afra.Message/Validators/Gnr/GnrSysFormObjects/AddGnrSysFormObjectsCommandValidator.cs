using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddGnrSysFormObjectsCommandValidator : AbstractValidator<AddGnrSysFormObjectsCommand>
    {
        public AddGnrSysFormObjectsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
