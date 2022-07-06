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
    public class AddPayVacRemainCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PayVacRemainId { get; set; }  
 
		public Nullable<Int32> PVRPersRef { get; set; }  
 
		public Nullable<Int32> PVRVacRef { get; set; }  
 
		public Nullable<Int32> PVRYear { get; set; }  
 
		public Nullable<Int32> PVRMonth { get; set; }  
 
		public Nullable<Int32> PVRDay { get; set; }  
 
		public Nullable<Int32> PVRHour { get; set; }  
 
		public Nullable<Int32> PVRMinute { get; set; }  
 
		public Nullable<Int32> PVRYearMonth { get; set; } 

        public void Validate()
        {
            new AddPayVacRemainCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
