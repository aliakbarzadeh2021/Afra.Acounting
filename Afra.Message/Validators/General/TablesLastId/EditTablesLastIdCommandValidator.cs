using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditTablesLastIdCommandValidator : AbstractValidator<EditTablesLastIdCommand>
    {
        public EditTablesLastIdCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
