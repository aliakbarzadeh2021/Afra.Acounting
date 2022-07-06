using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddCntAcquitInfsCommandValidator : AbstractValidator<AddCntAcquitInfsCommand>
    {
        public AddCntAcquitInfsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
