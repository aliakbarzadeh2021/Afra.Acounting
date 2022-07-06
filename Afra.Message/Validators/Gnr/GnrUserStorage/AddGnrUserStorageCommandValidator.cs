using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddGnrUserStorageCommandValidator : AbstractValidator<AddGnrUserStorageCommand>
    {
        public AddGnrUserStorageCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
