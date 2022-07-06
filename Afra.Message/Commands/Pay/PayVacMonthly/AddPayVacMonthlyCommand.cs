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
    public class AddPayVacMonthlyCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PayVacMonthlyId { get; set; }  
 
		public Nullable<Int32> PVMPersRef { get; set; }  
 
		public Nullable<Int32> PVMVacRef { get; set; }  
 
		public Nullable<Int32> PVMIssueYear { get; set; }  
 
		public Nullable<Int32> PVMIssueMonth { get; set; }  
 
		public Nullable<Int32> PVMEffectYear { get; set; }  
 
		public Nullable<Int32> PVMEffectMonth { get; set; }  
 
		public Nullable<Int32> PVMDay { get; set; }  
 
		public Nullable<Int32> PVMHour { get; set; }  
 
		public Nullable<Int32> PVMMinute { get; set; }  
 
		public Nullable<Int32> PVMIYearMonth { get; set; }  
 
		public Nullable<Int32> PVMEYearMonth { get; set; } 

        public void Validate()
        {
            new AddPayVacMonthlyCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
