using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditSMSOperateDetCommandValidator : AbstractValidator<EditSMSOperateDetCommand>
    {
        public EditSMSOperateDetCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
