using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddPayExportFilesCommandValidator : AbstractValidator<AddPayExportFilesCommand>
    {
        public AddPayExportFilesCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
