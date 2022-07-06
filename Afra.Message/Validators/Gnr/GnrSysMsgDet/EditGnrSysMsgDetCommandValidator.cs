using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditGnrSysMsgDetCommandValidator : AbstractValidator<EditGnrSysMsgDetCommand>
    {
        public EditGnrSysMsgDetCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
