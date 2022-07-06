using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddsysdiagramsCommandValidator : AbstractValidator<AddsysdiagramsCommand>
    {
        public AddsysdiagramsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
