using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddSMSOperateDetCommandValidator : AbstractValidator<AddSMSOperateDetCommand>
    {
        public AddSMSOperateDetCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
