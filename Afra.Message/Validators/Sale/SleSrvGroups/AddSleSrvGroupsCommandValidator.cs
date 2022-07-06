using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddSleSrvGroupsCommandValidator : AbstractValidator<AddSleSrvGroupsCommand>
    {
        public AddSleSrvGroupsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
