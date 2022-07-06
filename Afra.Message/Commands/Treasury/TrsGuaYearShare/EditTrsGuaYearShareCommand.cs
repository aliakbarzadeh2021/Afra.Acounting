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
    public class EditTrsGuaYearShareCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 TGYSItmRef { get; set; }  
 
		public Int32 TGYSItmType { get; set; }  
 
		public Int32 TGYSPeriodRef { get; set; }  
 
		public DateTime TGYSToDate { get; set; }  
 
		public Nullable<Double> TGYSVal { get; set; }  
 
		public String TGYSDescr { get; set; } 

        public void Validate()
        {
            new EditTrsGuaYearShareCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
