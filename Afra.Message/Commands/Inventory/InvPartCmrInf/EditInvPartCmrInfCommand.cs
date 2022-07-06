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
    public class EditInvPartCmrInfCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 InvPartCmrInfId { get; set; }  
 
		public Nullable<Int32> IPCIStockRef { get; set; }  
 
		public Nullable<Int32> IPCIPartRef { get; set; }  
 
		public Nullable<Double> IPCIMinQty { get; set; }  
 
		public Nullable<Double> IPCIMaxQty { get; set; }  
 
		public Nullable<Double> IPCIOrderLimit { get; set; }  
 
		public Nullable<Double> IPCIOrderQty { get; set; } 

        public void Validate()
        {
            new EditInvPartCmrInfCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
