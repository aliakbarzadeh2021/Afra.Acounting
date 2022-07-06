using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class PayExpDet : BaseEntity
    {
          
 
		public Int32 PayExpDetId { get; set; }  
 
		public Nullable<Int32> PayExpFileRef { get; set; }  
 
		public Nullable<Int32> PEDSeq { get; set; }  
 
		public Nullable<Int32> PEDLoc { get; set; }  
 
		public String PEDFieldRef { get; set; }  
 
		public String PEDName { get; set; }  
 
		public String PEDTitle { get; set; }  
 
		public Nullable<Int32> PEDFldType { get; set; }  
 
		public Nullable<Int32> PEDSize { get; set; }  
 
		public String PEDDefVal { get; set; }  
 
		public String PEDFill { get; set; } 
    }
}


