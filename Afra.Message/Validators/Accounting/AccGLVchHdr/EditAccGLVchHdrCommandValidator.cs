using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditAccGLVchHdrCommandValidator : AbstractValidator<EditAccGLVchHdrCommand>
    {
        public EditAccGLVchHdrCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
