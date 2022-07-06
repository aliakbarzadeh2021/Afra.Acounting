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
    public class EditInvFormItmCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 InvFormItmId { get; set; }  
 
		public Nullable<Int32> InvFormHdrRef { get; set; }  
 
		public Nullable<Int32> IFISeq { get; set; }  
 
		public Int32 IFIPartRef { get; set; }  
 
		public Nullable<Int32> IFIUnitRef { get; set; }  
 
		public Double IFIQty { get; set; }  
 
		public String IFIDescr { get; set; }  
 
		public Nullable<Int32> IFIRefID { get; set; }  
 
		public Nullable<Int32> IFIRefType { get; set; } 

        public void Validate()
        {
            new EditInvFormItmCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
