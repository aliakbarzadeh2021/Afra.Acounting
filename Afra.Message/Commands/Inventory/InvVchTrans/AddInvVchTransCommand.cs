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
    public class AddInvVchTransCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 InvVchTransId { get; set; }  
 
		public Nullable<Int32> InvVchItmRef { get; set; }  
 
		public String IVTNum { get; set; }  
 
		public DateTime IVTDater { get; set; }  
 
		public Nullable<Double> IVTQty { get; set; }  
 
		public String IVTDriver { get; set; }  
 
		public String IVTCarNo { get; set; }  
 
		public String IVTDescr { get; set; } 

        public void Validate()
        {
            new AddInvVchTransCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
