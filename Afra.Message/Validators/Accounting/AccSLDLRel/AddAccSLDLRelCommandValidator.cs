using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddAccSLDLRelCommandValidator : AbstractValidator<AddAccSLDLRelCommand>
    {
        public AddAccSLDLRelCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
