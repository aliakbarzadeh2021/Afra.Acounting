using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class SlePriceItmDto
    {
          
 
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
    }
}


