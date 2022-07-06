using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddAstTransDocsCommandValidator : AbstractValidator<AddAstTransDocsCommand>
    {
        public AddAstTransDocsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
