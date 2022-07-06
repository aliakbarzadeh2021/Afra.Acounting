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
    public class EditCmrSendItmCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CmrSendItmId { get; set; }  
 
		public Int32 CSISeq { get; set; }  
 
		public Int32 CmrSendHdrRef { get; set; }  
 
		public Nullable<Double> CSIOthQty { get; set; }  
 
		public Nullable<Double> CSIMainQty { get; set; }  
 
		public String CSIDescr { get; set; }  
 
		public Nullable<Int32> CSIStatus { get; set; }  
 
		public Nullable<Int32> CSIRefID { get; set; }  
 
		public Nullable<Int32> CSIRefType { get; set; }  
 
		public Nullable<Int32> CSIBaseType { get; set; } 

        public void Validate()
        {
            new EditCmrSendItmCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
