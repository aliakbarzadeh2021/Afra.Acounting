using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditQcsTestDocsCommandValidator : AbstractValidator<EditQcsTestDocsCommand>
    {
        public EditQcsTestDocsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
