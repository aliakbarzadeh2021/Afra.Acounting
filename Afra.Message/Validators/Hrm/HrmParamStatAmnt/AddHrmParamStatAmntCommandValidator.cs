using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddHrmParamStatAmntCommandValidator : AbstractValidator<AddHrmParamStatAmntCommand>
    {
        public AddHrmParamStatAmntCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
