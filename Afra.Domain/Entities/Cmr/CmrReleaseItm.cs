using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class CmrReleaseItm : BaseEntity
    {
          
 
		public Int32 CmrReleaseItmId { get; set; }  
 
		public Int32 CRISeq { get; set; }  
 
		public Int32 CmrReleaseHdrRef { get; set; }  
 
		public Nullable<Double> CRIOthQty { get; set; }  
 
		public Nullable<Double> CRIMainQty { get; set; }  
 
		public String CRITariffCode { get; set; }  
 
		public Nullable<Double> CRITariffAmnt { get; set; }  
 
		public Nullable<Double> CRITaxAmnt { get; set; }  
 
		public Nullable<Double> CRIDutyAmnt { get; set; }  
 
		public String CRIDescr { get; set; }  
 
		public Nullable<Int32> CRIStatus { get; set; }  
 
		public Nullable<Int32> CRIRefID { get; set; }  
 
		public Nullable<Int32> CRIRefType { get; set; }  
 
		public Nullable<Int32> CRIBaseType { get; set; } 
    }
}


