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
    public class AddBdgShareRepCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 BdgShareRepId { get; set; }  
 
		public Int32 BSRPeriodId { get; set; }  
 
		public String BSRCstLevel { get; set; }  
 
		public String BSRPutCst { get; set; }  
 
		public String BSRRcvCst { get; set; }  
 
		public Double BSRCostVal { get; set; } 

        public void Validate()
        {
            new AddBdgShareRepCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
