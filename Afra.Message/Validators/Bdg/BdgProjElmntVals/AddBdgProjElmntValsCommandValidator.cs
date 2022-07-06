using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddBdgProjElmntValsCommandValidator : AbstractValidator<AddBdgProjElmntValsCommand>
    {
        public AddBdgProjElmntValsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
