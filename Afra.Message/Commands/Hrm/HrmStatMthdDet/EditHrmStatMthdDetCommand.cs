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
    public class EditHrmStatMthdDetCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 HrmStatMthdDetId { get; set; }  
 
		public Nullable<Int32> HSMDMthdRef { get; set; }  
 
		public String HSMDParamName { get; set; }  
 
		public String HSMDParamTitle { get; set; }  
 
		public String HSMDMainParam { get; set; } 

        public void Validate()
        {
            new EditHrmStatMthdDetCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
