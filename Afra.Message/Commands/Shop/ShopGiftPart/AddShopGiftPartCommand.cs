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
    public class AddShopGiftPartCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 ShopGiftPartId { get; set; }  
 
		public Int32 SGPPartRef { get; set; }  
 
		public DateTime SGPDate { get; set; }  
 
		public Double SGPVchAmnt { get; set; }  
 
		public Double SGPVal { get; set; } 

        public void Validate()
        {
            new AddShopGiftPartCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
