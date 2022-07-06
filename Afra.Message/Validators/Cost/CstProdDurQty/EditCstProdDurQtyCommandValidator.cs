using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditCstProdDurQtyCommandValidator : AbstractValidator<EditCstProdDurQtyCommand>
    {
        public EditCstProdDurQtyCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
