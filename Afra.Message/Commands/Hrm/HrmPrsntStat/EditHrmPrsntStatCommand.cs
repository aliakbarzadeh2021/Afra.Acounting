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
    public class EditHrmPrsntStatCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 HrmPrsntStatId { get; set; }  
 
		public Nullable<Int32> HPSType { get; set; }  
 
		public Nullable<Int32> HPSNum { get; set; }  
 
		public DateTime HPSDate { get; set; }  
 
		public Nullable<Int32> HPSPersRef { get; set; }  
 
		public DateTime HPSFromDate { get; set; }  
 
		public DateTime HPSToDate { get; set; } 

        public void Validate()
        {
            new EditHrmPrsntStatCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
