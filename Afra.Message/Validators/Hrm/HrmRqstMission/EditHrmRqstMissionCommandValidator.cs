using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditHrmRqstMissionCommandValidator : AbstractValidator<EditHrmRqstMissionCommand>
    {
        public EditHrmRqstMissionCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
