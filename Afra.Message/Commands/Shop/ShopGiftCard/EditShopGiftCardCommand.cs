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
    public class EditShopGiftCardCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 ShopGiftCardId { get; set; }  
 
		public String SGCNumber { get; set; }  
 
		public Double SGCAmount { get; set; }  
 
		public DateTime SGCExpDate { get; set; }  
 
		public String SGCDescr { get; set; }  
 
		public Nullable<Int32> SGCGrpRef { get; set; }  
 
		public Nullable<Int32> SGCState { get; set; } 

        public void Validate()
        {
            new EditShopGiftCardCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
