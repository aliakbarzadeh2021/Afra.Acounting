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
    public class AddHrmGrpParamStatCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 HrmGrpParamStatId { get; set; }  
 
		public Nullable<Int32> HGPSNum { get; set; }  
 
		public DateTime HGPSIssueDate { get; set; }  
 
		public DateTime HGPSEffectDate { get; set; }  
 
		public String HGPSDescr { get; set; } 

        public void Validate()
        {
            new AddHrmGrpParamStatCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
