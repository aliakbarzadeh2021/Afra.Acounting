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
    public class EditSleFixAccCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 SFAGroupRef { get; set; }  
 
		public String SFACstmrRcv { get; set; }  
 
		public String SFACstmrPay { get; set; }  
 
		public String SFACstmrPre { get; set; }  
 
		public Nullable<Int32> SFADL4Type { get; set; }  
 
		public Nullable<Int32> SFADL5Type { get; set; }  
 
		public Nullable<Int32> SFADL6Type { get; set; } 

        public void Validate()
        {
            new EditSleFixAccCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
