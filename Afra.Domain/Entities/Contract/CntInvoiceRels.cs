using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class CntInvoiceRels : BaseEntity
    {
          
 
		public Int32 CntInvoiceRelId { get; set; }  
 
		public String CIRLabel { get; set; }  
 
		public String CIRRatioField { get; set; }  
 
		public String CIRCalcField { get; set; }  
 
		public String CIRPayField { get; set; }  
 
		public String CIRPayAccCode { get; set; }  
 
		public Nullable<Int32> CIRHaveRet { get; set; }  
 
		public Nullable<Int32> CIRPriovity { get; set; }  
 
		public Int32 CIROprType { get; set; }  
 
		public Nullable<Int32> CIRRetCtrl { get; set; }  
 
		public Nullable<Int32> CIRRetCtrl2 { get; set; }  
 
		public Nullable<Int32> CIRCheckDate { get; set; } 
    }
}


