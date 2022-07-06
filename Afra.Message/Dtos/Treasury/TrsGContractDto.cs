using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class TrsGContractDto
    {
          
 
		public Int32 TrsGuaContractId { get; set; }  
 
		public Int32 TGCType { get; set; }  
 
		public String TGCKind { get; set; }  
 
		public String TGCNum { get; set; }  
 
		public String TGCDescr { get; set; }  
 
		public DateTime TGCDate { get; set; }  
 
		public Nullable<Double> TGCAmount { get; set; }  
 
		public String TGCSLRef { get; set; }  
 
		public Nullable<Int32> TGCCreator { get; set; }  
 
		public Nullable<Int32> TGCSit { get; set; } 
    }
}


