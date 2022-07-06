using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class PrdOperation : BaseEntity
    {
          
 
		public Int32 PrdOperationId { get; set; }  
 
		public Int32 PONum { get; set; }  
 
		public DateTime PODate { get; set; }  
 
		public Int32 POStationRef { get; set; }  
 
		public String PODescr { get; set; }  
 
		public Nullable<Int32> Creator { get; set; }  
 
		public Nullable<Int32> Confimer { get; set; }  
 
		public Nullable<Int32> POState { get; set; }  
 
		public Nullable<Int32> POYear { get; set; } 
    }
}


