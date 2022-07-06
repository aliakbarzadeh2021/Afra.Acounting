using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class CstStdCalc : BaseEntity
    {
          
 
		public Int32 CstStdCalcId { get; set; }  
 
		public Nullable<Int32> CSCPeriodId { get; set; }  
 
		public Nullable<Int32> CSCProductRef { get; set; }  
 
		public Nullable<Int32> CSCFormulaRef { get; set; }  
 
		public Nullable<Int32> CSCMatRef { get; set; }  
 
		public Nullable<Int32> CSCCostCntrRef { get; set; }  
 
		public Nullable<Double> CSCQty { get; set; }  
 
		public Nullable<Double> CSCRate { get; set; }  
 
		public Nullable<Double> CSCAmount { get; set; }  
 
		public Nullable<Double> CSCWast { get; set; }  
 
		public String CSCSLCode { get; set; }  
 
		public Nullable<Int32> CSCCostType { get; set; }  
 
		public Nullable<Double> CSCHrmFix { get; set; }  
 
		public Nullable<Double> CSCHrmChng { get; set; }  
 
		public Nullable<Double> CSCCostFix { get; set; }  
 
		public Nullable<Double> CSCCostChng { get; set; }  
 
		public Nullable<Double> CSCOthCost { get; set; }  
 
		public Nullable<Int32> CSCMatType { get; set; } 
    }
}


