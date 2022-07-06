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
    public class EditCmrOrdItmCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CmrOrdItmId { get; set; }  
 
		public Int32 COISeq { get; set; }  
 
		public Int32 CmrOrdHdrRef { get; set; }  
 
		public Int32 COIRqstRef { get; set; }  
 
		public Nullable<Double> COIOthQty { get; set; }  
 
		public Nullable<Double> COIMainQty { get; set; }  
 
		public Nullable<Double> COIAmount { get; set; }  
 
		public String COIDescr { get; set; }  
 
		public Nullable<Int32> COIStatus { get; set; } 

        public void Validate()
        {
            new EditCmrOrdItmCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
