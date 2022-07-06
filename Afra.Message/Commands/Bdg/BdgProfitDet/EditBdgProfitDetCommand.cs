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
    public class EditBdgProfitDetCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 BdgProfitDetId { get; set; }  
 
		public String BPDDLRef { get; set; }  
 
		public String BPDDL5Ref { get; set; }  
 
		public String BPDDL6Ref { get; set; }  
 
		public String BPDDL7Ref { get; set; }  
 
		public Double BPDPercent { get; set; }  
 
		public Int32 BPDPeriodRef { get; set; } 

        public void Validate()
        {
            new EditBdgProfitDetCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
