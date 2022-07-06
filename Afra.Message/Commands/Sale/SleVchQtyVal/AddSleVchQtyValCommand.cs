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
    public class AddSleVchQtyValCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 SleVchQtyValId { get; set; }  
 
		public Int32 SVQVchItmRef { get; set; }  
 
		public Nullable<Int32> SVQPrjRef { get; set; }  
 
		public String SVQDLRef { get; set; }  
 
		public Nullable<Int32> SVQProductRef { get; set; }  
 
		public String SVQOthVal { get; set; }  
 
		public String SVQOthDate { get; set; }  
 
		public Double SVQQty { get; set; } 

        public void Validate()
        {
            new AddSleVchQtyValCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
