using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class CntExpnsAccntsDto
    {
          
 
		public Int32 CntExpAccId { get; set; }  
 
		public String CEANum { get; set; }  
 
		public DateTime CEADate { get; set; }  
 
		public String CEAType { get; set; }  
 
		public String CEADescr { get; set; }  
 
		public Int32 CEAContrRef { get; set; }  
 
		public Nullable<Double> CEAAllAmnt { get; set; }  
 
		public Nullable<Double> CEAAmount { get; set; }  
 
		public Nullable<Int32> CEAAmntType { get; set; }  
 
		public Nullable<Int32> CEAIsSum { get; set; }  
 
		public Nullable<Int32> CEAAccPrdRef { get; set; }  
 
		public Nullable<Int32> CEAState { get; set; }  
 
		public Nullable<Double> CEAThisAmnt { get; set; }  
 
		public Nullable<Int32> Creator { get; set; }  
 
		public Nullable<Int32> Confimer { get; set; }  
 
		public Nullable<Int32> CEACurRef { get; set; }  
 
		public Nullable<Double> CEACurRate { get; set; }  
 
		public Nullable<Double> CEACurAmnt { get; set; }  
 
		public String CEALocNum { get; set; }  
 
		public Nullable<Int32> CEAContractorRef { get; set; } 
    }
}

