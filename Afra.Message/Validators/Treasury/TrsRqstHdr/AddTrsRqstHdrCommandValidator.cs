using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddTrsRqstHdrCommandValidator : AbstractValidator<AddTrsRqstHdrCommand>
    {
        public AddTrsRqstHdrCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
