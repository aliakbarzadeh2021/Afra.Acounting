using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddPrdPOrdHdrCommandValidator : AbstractValidator<AddPrdPOrdHdrCommand>
    {
        public AddPrdPOrdHdrCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
