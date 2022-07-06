using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditUsrExhibitionRqstCommandValidator : AbstractValidator<EditUsrExhibitionRqstCommand>
    {
        public EditUsrExhibitionRqstCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
