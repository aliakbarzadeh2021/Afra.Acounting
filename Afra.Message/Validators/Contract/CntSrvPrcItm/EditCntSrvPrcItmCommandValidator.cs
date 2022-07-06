using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditCntSrvPrcItmCommandValidator : AbstractValidator<EditCntSrvPrcItmCommand>
    {
        public EditCntSrvPrcItmCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
