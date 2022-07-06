using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddGnrSysTablesCommandValidator : AbstractValidator<AddGnrSysTablesCommand>
    {
        public AddGnrSysTablesCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
