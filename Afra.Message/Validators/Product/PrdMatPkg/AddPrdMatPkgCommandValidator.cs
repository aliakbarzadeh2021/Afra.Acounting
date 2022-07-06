using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddPrdMatPkgCommandValidator : AbstractValidator<AddPrdMatPkgCommand>
    {
        public AddPrdMatPkgCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
