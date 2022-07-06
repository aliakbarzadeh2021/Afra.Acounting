using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddCntExpAcntDataCommandValidator : AbstractValidator<AddCntExpAcntDataCommand>
    {
        public AddCntExpAcntDataCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
