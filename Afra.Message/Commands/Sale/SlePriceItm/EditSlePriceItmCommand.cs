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
    public class EditSlePriceItmCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 SlePriceItmId { get; set; }  
 
		public Int32 SlePriceHdrRef { get; set; }  
 
		public Nullable<Int32> SPISeq { get; set; }  
 
		public Nullable<Int32> SPICstmrGrpRef { get; set; }  
 
		public Nullable<Int32> SPIPartRef { get; set; }  
 
		public Nullable<Int32> SPIUnitRef { get; set; }  
 
		public Double SPIMinQty { get; set; }  
 
		public Double SPIMaxQty { get; set; }  
 
		public Double SPIUnitPrice { get; set; }  
 
		public Int32 SPIPriceSit { get; set; }  
 
		public Nullable<Int32> SPIPartGrpRef { get; set; }  
 
		public Nullable<Int32> SPIPlaceRef { get; set; }  
 
		public Nullable<Int32> SPISaleType { get; set; } 

        public void Validate()
        {
            new EditSlePriceItmCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
