using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddUsrExhibitionRqstCommandValidator : AbstractValidator<AddUsrExhibitionRqstCommand>
    {
        public AddUsrExhibitionRqstCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
