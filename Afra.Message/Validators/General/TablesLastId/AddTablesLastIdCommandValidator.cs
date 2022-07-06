using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddTablesLastIdCommandValidator : AbstractValidator<AddTablesLastIdCommand>
    {
        public AddTablesLastIdCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
