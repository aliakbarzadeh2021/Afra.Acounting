using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class AccNoteItm : BaseEntity
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


