using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class TrsFunds : BaseEntity
    {
          
 
		public Int32 TrsFundId { get; set; }  
 
		public String TFTitle { get; set; }  
 
		public Nullable<Int32> TFCrsRef { get; set; }  
 
		public DateTime TFOpenDate { get; set; }  
 
		public Double TFBeginAmnt { get; set; }  
 
		public Nullable<Double> TFMaxAmnt { get; set; }  
 
		public String TFSLRef { get; set; }  
 
		public String TFDLRef { get; set; }  
 
		public String TFDLFive { get; set; }  
 
		public String TFDLSix { get; set; } 
    }
}


