using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditGnrTableRelationCommandValidator : AbstractValidator<EditGnrTableRelationCommand>
    {
        public EditGnrTableRelationCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
