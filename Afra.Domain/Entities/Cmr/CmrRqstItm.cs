using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class CmrRqstItm : BaseEntity
    {
          
 
		public Int32 CmrRqstItmId { get; set; }  
 
		public Int32 CRISeq { get; set; }  
 
		public Int32 CmrRqstHdrRef { get; set; }  
 
		public Nullable<Int32> CRIServiceRef { get; set; }  
 
		public Nullable<Int32> CRIPartRef { get; set; }  
 
		public Nullable<Int32> CRIUnitRef { get; set; }  
 
		public Nullable<Double> CRIOthQty { get; set; }  
 
		public Nullable<Double> CRIMainQty { get; set; }  
 
		public Nullable<Int32> CRIOfferSeller { get; set; }  
 
		public String CRIDescr { get; set; }  
 
		public DateTime CRINeedDate { get; set; }  
 
		public Nullable<Int32> CRIStatus { get; set; }  
 
		public Nullable<Int32> CRIRefID { get; set; }  
 
		public Nullable<Int32> CRIRefType { get; set; } 
    }
}


