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
    public class AddBdgHrmBaseCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 BdgHrmBaseId { get; set; }  
 
		public Int32 BHBCostCenter { get; set; }  
 
		public Int32 BHBCurPersCnt { get; set; }  
 
		public Int32 BHBBdgPersCnt { get; set; }  
 
		public Int32 BHBPeriodRef { get; set; } 

        public void Validate()
        {
            new AddBdgHrmBaseCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
