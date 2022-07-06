using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddPrdOrdSchedCommandValidator : AbstractValidator<AddPrdOrdSchedCommand>
    {
        public AddPrdOrdSchedCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
