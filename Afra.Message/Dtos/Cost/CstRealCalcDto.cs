using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class CstRealCalcDto
    {
          
 
		public Int32 CstRealCalcId { get; set; }  
 
		public Nullable<Int32> CRCPeriodId { get; set; }  
 
		public Nullable<Int32> CRCProductRef { get; set; }  
 
		public Nullable<Int32> CRCFormulaRef { get; set; }  
 
		public Nullable<Int32> CRCMatRef { get; set; }  
 
		public Nullable<Int32> CRCCostCntrRef { get; set; }  
 
		public Nullable<Double> CRCQty { get; set; }  
 
		public Nullable<Double> CRCRate { get; set; }  
 
		public Nullable<Double> CRCAmount { get; set; }  
 
		public Nullable<Double> CRCWast { get; set; }  
 
		public String CRCSLCode { get; set; }  
 
		public Nullable<Int32> CRCCostType { get; set; }  
 
		public Nullable<Double> CRCHrmFix { get; set; }  
 
		public Nullable<Double> CRCHrmChng { get; set; }  
 
		public Nullable<Double> CRCCostFix { get; set; }  
 
		public Nullable<Double> CRCCostChng { get; set; }  
 
		public Nullable<Double> CRCOthCost { get; set; }  
 
		public Nullable<Int32> CRCMatType { get; set; } 
    }
}


