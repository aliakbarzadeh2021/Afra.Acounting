using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditCntSrvItemsCommandValidator : AbstractValidator<EditCntSrvItemsCommand>
    {
        public EditCntSrvItemsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
