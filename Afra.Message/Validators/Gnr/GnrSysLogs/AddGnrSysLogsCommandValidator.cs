using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddGnrSysLogsCommandValidator : AbstractValidator<AddGnrSysLogsCommand>
    {
        public AddGnrSysLogsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
