using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class StkStockDocs : BaseEntity
    {
          
 
		public Int32 StkStockDocId { get; set; }  
 
		public Int32 SSDStockerRef { get; set; }  
 
		public Int32 SSDType { get; set; }  
 
		public Int32 SSDNum { get; set; }  
 
		public Double SSDQty { get; set; }  
 
		public Int32 SSDState { get; set; }  
 
		public Int32 SSDPeriodRef { get; set; } 
    }
}


