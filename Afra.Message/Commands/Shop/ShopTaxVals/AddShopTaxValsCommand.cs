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
    public class AddShopTaxValsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 ShopTaxValsId { get; set; }  
 
		public Int32 STVTaxRef { get; set; }  
 
		public DateTime STVDate { get; set; }  
 
		public Nullable<Int32> STVPartRef { get; set; }  
 
		public String STVDescr { get; set; }  
 
		public Nullable<Double> STVAmount { get; set; } 

        public void Validate()
        {
            new AddShopTaxValsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
