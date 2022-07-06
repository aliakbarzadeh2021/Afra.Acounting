using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class SlePriceHdrDto
    {
          
 
		public Int32 SlePriceHdrID { get; set; }  
 
		public Int32 SPHNum { get; set; }  
 
		public Nullable<Int32> SPHLocalNum { get; set; }  
 
		public DateTime SPHDate { get; set; }  
 
		public String SPHDescr { get; set; }  
 
		public Int32 SPHBranchRef { get; set; }  
 
		public Nullable<Int32> Creator { get; set; }  
 
		public Nullable<Int32> Confimer { get; set; }  
 
		public Nullable<Int32> SPHState { get; set; }  
 
		public Nullable<Int32> SPAccPrdRef { get; set; } 
    }
}


