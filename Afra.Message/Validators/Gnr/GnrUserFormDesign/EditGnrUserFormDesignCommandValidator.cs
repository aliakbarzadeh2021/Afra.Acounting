using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditGnrUserFormDesignCommandValidator : AbstractValidator<EditGnrUserFormDesignCommand>
    {
        public EditGnrUserFormDesignCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
