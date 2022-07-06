using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class PrdOprDet : BaseEntity
    {
          
 
		public Int32 PrdOprDetId { get; set; }  
 
		public Int32 PrdOperationRef { get; set; }  
 
		public Int32 PODSeq { get; set; }  
 
		public Int32 PODSchRef { get; set; }  
 
		public DateTime PODRSTime { get; set; }  
 
		public DateTime PODRETime { get; set; }  
 
		public Double PODProdQty { get; set; }  
 
		public Double PODWastQty { get; set; }  
 
		public Double PODUnQty { get; set; } 
    }
}


