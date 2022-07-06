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
    public class AddCmrSellersCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CmrSellerId { get; set; }  
 
		public Int32 CSCrspndRef { get; set; }  
 
		public Int32 CSType { get; set; }  
 
		public Nullable<Int32> CSActive { get; set; }  
 
		public Nullable<Int32> CSGroupRef { get; set; } 

        public void Validate()
        {
            new AddCmrSellersCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
