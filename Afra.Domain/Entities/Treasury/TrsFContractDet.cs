using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class TrsFContractDet : BaseEntity
    {
          
 
		public Int32 TrsFContractDetId { get; set; }  
 
		public Int32 TFCDType { get; set; }  
 
		public Int32 TFCDItmRef { get; set; }  
 
		public Int32 TFCDSrcRef { get; set; }  
 
		public Double TFCDPrc { get; set; } 
    }
}


