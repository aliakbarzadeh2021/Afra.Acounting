using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditSleSrvGroupsCommandValidator : AbstractValidator<EditSleSrvGroupsCommand>
    {
        public EditSleSrvGroupsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
