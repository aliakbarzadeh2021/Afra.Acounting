using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class PartFormula : BaseEntity
    {
          
 
		public Int32 PartFormulaId { get; set; }  
 
		public Int32 PFProductRef { get; set; }  
 
		public Nullable<Int32> PFType { get; set; }  
 
		public String PFTitle { get; set; }  
 
		public DateTime PFDate { get; set; }  
 
		public Nullable<Int32> PFCostPeriod { get; set; }  
 
		public Nullable<Int32> PFCostCenter { get; set; }  
 
		public Nullable<Int32> PFStep { get; set; }  
 
		public Double PFQty { get; set; }  
 
		public Nullable<Int32> PFParent { get; set; }  
 
		public Nullable<Int32> PFHrmTime { get; set; }  
 
		public Nullable<Int32> PFHrmCnt { get; set; }  
 
		public Nullable<Int32> PFCstTime { get; set; } 
    }
}


