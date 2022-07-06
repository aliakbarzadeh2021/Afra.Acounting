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
    public class EditShopPartPriceCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 ShopPartPriceId { get; set; }  
 
		public DateTime SPPDate { get; set; }  
 
		public Int32 SPPPartRef { get; set; }  
 
		public Int32 SPPSaleType { get; set; }  
 
		public Double SPPVal { get; set; } 

        public void Validate()
        {
            new EditShopPartPriceCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
