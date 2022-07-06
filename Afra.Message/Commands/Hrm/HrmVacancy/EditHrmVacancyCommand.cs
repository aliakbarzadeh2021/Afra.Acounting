using Afra.Message.Base;
using Afra.Message.Extentions;
using Afra.Message.Validators;
using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Commands
{
    /// <summary>
    ///  
    /// </summary>
    public class EditHrmVacancyCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 HrmVacancyId { get; set; }  
 
		public String HVTitle { get; set; }  
 
		public Nullable<Int32> HVType { get; set; }  
 
		public Nullable<Int32> HVRole { get; set; } 

        public void Validate()
        {
            new EditHrmVacancyCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
