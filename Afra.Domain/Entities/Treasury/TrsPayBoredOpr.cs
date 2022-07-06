using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class TrsPayBoredOpr : BaseEntity
    {
          
 
		public Int32 PBOHdrId { get; set; }  
 
		public Int32 PBONum { get; set; }  
 
		public Nullable<Int32> PBOLocalNum { get; set; }  
 
		public DateTime PBODate { get; set; }  
 
		public String PBODescr { get; set; }  
 
		public Nullable<Int32> Creator { get; set; }  
 
		public Nullable<Int32> Confimer { get; set; }  
 
		public Nullable<Int32> PBOState { get; set; }  
 
		public Nullable<Int32> TPAccPrdRef { get; set; }  
 
		public Nullable<Int32> PBOCreator { get; set; }  
 
		public Nullable<Int32> PBOSit { get; set; } 
    }
}


