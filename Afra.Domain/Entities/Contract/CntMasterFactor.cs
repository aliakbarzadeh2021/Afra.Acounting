using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class CntMasterFactor : BaseEntity
    {
          
 
		public Int32 CntMasterFactorId { get; set; }  
 
		public Nullable<Int32> CMFSerial { get; set; }  
 
		public Nullable<Int32> CMFNum { get; set; }  
 
		public DateTime CMFDate { get; set; }  
 
		public Int32 CMFContRef { get; set; }  
 
		public Double CMFAmount { get; set; }  
 
		public String CMFDescr { get; set; }  
 
		public Int32 CMFPrdRef { get; set; }  
 
		public Nullable<Int32> CMFState { get; set; }  
 
		public Nullable<Int32> Creator { get; set; }  
 
		public Nullable<Int32> Confimer { get; set; } 
    }
}


