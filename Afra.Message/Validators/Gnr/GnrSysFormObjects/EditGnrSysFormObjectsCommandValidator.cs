using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditGnrSysFormObjectsCommandValidator : AbstractValidator<EditGnrSysFormObjectsCommand>
    {
        public EditGnrSysFormObjectsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
