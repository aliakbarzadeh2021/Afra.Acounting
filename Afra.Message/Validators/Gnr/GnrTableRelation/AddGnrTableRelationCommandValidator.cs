using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddGnrTableRelationCommandValidator : AbstractValidator<AddGnrTableRelationCommand>
    {
        public AddGnrTableRelationCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
