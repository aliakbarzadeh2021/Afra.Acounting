using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddCntAccVchTypesCommandValidator : AbstractValidator<AddCntAccVchTypesCommand>
    {
        public AddCntAccVchTypesCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
