using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class CntInvoiceDet : BaseEntity
    {
          
 
		public Int32 CntInvoiceDetId { get; set; }  
 
		public Nullable<Int32> CIDType { get; set; }  
 
		public Int32 CIDRelRef { get; set; }  
 
		public Int32 CIDExpAcntRef { get; set; }  
 
		public String CIDLabel { get; set; }  
 
		public String CIDRatio { get; set; }  
 
		public Nullable<Int64> CIDCalc { get; set; }  
 
		public Nullable<Int64> CIDPay { get; set; }  
 
		public Nullable<Int32> CIDHaveRet { get; set; }  
 
		public Nullable<Double> CIDExpVal { get; set; }  
 
		public Nullable<Int32> CIDHdrRef { get; set; } 
    }
}


