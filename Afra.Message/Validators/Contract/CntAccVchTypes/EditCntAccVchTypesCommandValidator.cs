using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditCntAccVchTypesCommandValidator : AbstractValidator<EditCntAccVchTypesCommand>
    {
        public EditCntAccVchTypesCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
