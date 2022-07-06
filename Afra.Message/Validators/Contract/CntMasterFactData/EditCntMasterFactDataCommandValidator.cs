using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditCntMasterFactDataCommandValidator : AbstractValidator<EditCntMasterFactDataCommand>
    {
        public EditCntMasterFactDataCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
