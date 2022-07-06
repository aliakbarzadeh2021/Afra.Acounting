using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditsysdiagramsCommandValidator : AbstractValidator<EditsysdiagramsCommand>
    {
        public EditsysdiagramsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
