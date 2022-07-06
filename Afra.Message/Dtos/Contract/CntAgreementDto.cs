using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class CntAgreementDto
    {
          
 
		public Int32 CntAgrmntId { get; set; }  
 
		public String CAgNum { get; set; }  
 
		public DateTime CAgDate { get; set; }  
 
		public String CAgDescr { get; set; }  
 
		public Int32 CAgMasterRef { get; set; }  
 
		public Nullable<Int32> CAgAmntSit { get; set; }  
 
		public Nullable<Double> CAgAmount { get; set; }  
 
		public String CAgDur { get; set; }  
 
		public Nullable<Double> CAgRatio { get; set; }  
 
		public Nullable<Int32> CAgAccPrdRef { get; set; } 
    }
}


