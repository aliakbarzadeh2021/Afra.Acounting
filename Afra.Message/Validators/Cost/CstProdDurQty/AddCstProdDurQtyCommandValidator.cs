using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddCstProdDurQtyCommandValidator : AbstractValidator<AddCstProdDurQtyCommand>
    {
        public AddCstProdDurQtyCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
