using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditCntAcquitInfsCommandValidator : AbstractValidator<EditCntAcquitInfsCommand>
    {
        public EditCntAcquitInfsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
