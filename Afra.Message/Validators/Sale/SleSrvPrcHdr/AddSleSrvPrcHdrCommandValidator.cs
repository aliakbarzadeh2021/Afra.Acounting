using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddSleSrvPrcHdrCommandValidator : AbstractValidator<AddSleSrvPrcHdrCommand>
    {
        public AddSleSrvPrcHdrCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
