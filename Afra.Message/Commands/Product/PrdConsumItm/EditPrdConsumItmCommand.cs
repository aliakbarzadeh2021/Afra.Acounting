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
    public class EditPrdConsumItmCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PrdConsumItmId { get; set; }  
 
		public Nullable<Int32> PrdConsumHdrRef { get; set; }  
 
		public Nullable<Int32> PCISeq { get; set; }  
 
		public Int32 PCIPartRef { get; set; }  
 
		public Nullable<Int32> PCIUnitRef { get; set; }  
 
		public Double PCIQty { get; set; }  
 
		public String PCIDescr { get; set; } 

        public void Validate()
        {
            new EditPrdConsumItmCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
