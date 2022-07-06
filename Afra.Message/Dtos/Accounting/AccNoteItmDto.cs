using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class AccNoteItmDto
    {
          
 
		public Int32 AccNoteItmId { get; set; }  
 
		public Int32 AccNoteHdrRef { get; set; }  
 
		public String ANISLRef { get; set; }  
 
		public DateTime ANIItmDate { get; set; }  
 
		public String ANIDescr { get; set; }  
 
		public Nullable<Double> ANIDebit { get; set; }  
 
		public Nullable<Double> ANICredit { get; set; } 
    }
}


