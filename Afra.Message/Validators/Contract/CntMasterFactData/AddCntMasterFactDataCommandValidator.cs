using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddCntMasterFactDataCommandValidator : AbstractValidator<AddCntMasterFactDataCommand>
    {
        public AddCntMasterFactDataCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
