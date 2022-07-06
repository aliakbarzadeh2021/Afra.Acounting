using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class TrsPayBoredItmDto
    {
          
 
		public Int32 PayBoredOprItmId { get; set; }  
 
		public Nullable<Int32> PBOHdrRef { get; set; }  
 
		public Int32 PBOIAccOprRef { get; set; }  
 
		public Nullable<Int32> PBOIBankAccRef { get; set; }  
 
		public Nullable<Int32> PBOICashRef { get; set; }  
 
		public Int32 PBOIBoredRef { get; set; }  
 
		public Nullable<Int32> PBOISeq { get; set; }  
 
		public String PBOIDescr { get; set; }  
 
		public DateTime PBOIDate { get; set; }  
 
		public String PBOIDLRef { get; set; } 
    }
}


