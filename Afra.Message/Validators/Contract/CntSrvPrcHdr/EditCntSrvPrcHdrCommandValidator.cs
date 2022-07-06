using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditCntSrvPrcHdrCommandValidator : AbstractValidator<EditCntSrvPrcHdrCommand>
    {
        public EditCntSrvPrcHdrCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
