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
    public class AddCntSrvPrcItmCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CntSrvPrcItmId { get; set; }  
 
		public Int32 CntSrvPrcHdrRef { get; set; }  
 
		public Nullable<Int32> CSPISeq { get; set; }  
 
		public Nullable<Int32> CSPIItemRef { get; set; }  
 
		public Nullable<Int32> CSPIUnitRef { get; set; }  
 
		public Double CSPIMinQty { get; set; }  
 
		public Double CSPIMaxQty { get; set; }  
 
		public Double CSPIUnitSrvPrc { get; set; } 

        public void Validate()
        {
            new AddCntSrvPrcItmCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
