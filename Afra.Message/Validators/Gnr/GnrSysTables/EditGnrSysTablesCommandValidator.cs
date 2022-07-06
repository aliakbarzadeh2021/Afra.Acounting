using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditGnrSysTablesCommandValidator : AbstractValidator<EditGnrSysTablesCommand>
    {
        public EditGnrSysTablesCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
