using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddGnrProcessDetObjCommandValidator : AbstractValidator<AddGnrProcessDetObjCommand>
    {
        public AddGnrProcessDetObjCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
