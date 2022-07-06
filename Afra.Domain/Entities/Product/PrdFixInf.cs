using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class PrdFixInf : BaseEntity
    {
          
 
		public Int32 PrdFixInfID { get; set; }  
 
		public Nullable<Int32> PFIProdVchType { get; set; }  
 
		public Nullable<Int32> PFIExpnsVchType { get; set; }  
 
		public Nullable<Int32> PFIMatStkRef { get; set; }  
 
		public Nullable<Int32> PFIPrdStkRef { get; set; }  
 
		public Nullable<Int32> PFISemiStkRef { get; set; }  
 
		public Nullable<Int32> PFIBaseVchType { get; set; } 
    }
}


