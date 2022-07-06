using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddPrdOrdHdrCommandValidator : AbstractValidator<AddPrdOrdHdrCommand>
    {
        public AddPrdOrdHdrCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
