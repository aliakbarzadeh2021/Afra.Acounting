using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddPrdConsumHdrCommandValidator : AbstractValidator<AddPrdConsumHdrCommand>
    {
        public AddPrdConsumHdrCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
