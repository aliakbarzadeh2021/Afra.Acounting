using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddPrdPOrdItmCommandValidator : AbstractValidator<AddPrdPOrdItmCommand>
    {
        public AddPrdPOrdItmCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
