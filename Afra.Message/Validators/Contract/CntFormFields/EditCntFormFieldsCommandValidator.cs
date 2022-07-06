using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditCntFormFieldsCommandValidator : AbstractValidator<EditCntFormFieldsCommand>
    {
        public EditCntFormFieldsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
