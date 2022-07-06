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
    public class AddTrsFacYearShareCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 TFYSFacRef { get; set; }  
 
		public Int32 TFYSPeriodRef { get; set; }  
 
		public DateTime TFYSToDate { get; set; }  
 
		public Nullable<Double> TFYSVal { get; set; }  
 
		public String TFYSDescr { get; set; } 

        public void Validate()
        {
            new AddTrsFacYearShareCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
