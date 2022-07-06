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
    public class EditSleCstmrsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 SleCstmrId { get; set; }  
 
		public String SleCstmrCode { get; set; }  
 
		public Nullable<Int32> SCGroupRef { get; set; }  
 
		public Int32 SCCrspndRef { get; set; }  
 
		public String SCSaleType { get; set; }  
 
		public Nullable<Int32> SCLimitType { get; set; }  
 
		public Nullable<Int32> SCType { get; set; } 

        public void Validate()
        {
            new EditSleCstmrsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
