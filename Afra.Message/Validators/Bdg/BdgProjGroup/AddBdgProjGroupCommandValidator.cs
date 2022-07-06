using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddBdgProjGroupCommandValidator : AbstractValidator<AddBdgProjGroupCommand>
    {
        public AddBdgProjGroupCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
