using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class PayVchDet : BaseEntity
    {
          
 
		public Int32 PayVchDetId { get; set; }  
 
		public Nullable<Int32> PayVchTypeRef { get; set; }  
 
		public String PVDDescr { get; set; }  
 
		public Nullable<Int32> PVDElmntRef { get; set; }  
 
		public String PVDSLRef { get; set; }  
 
		public Nullable<Int32> PVDBalance { get; set; }  
 
		public Nullable<Int32> PVDKind { get; set; }  
 
		public Nullable<Int32> PVDDLFour { get; set; }  
 
		public Nullable<Int32> PVDDLFive { get; set; }  
 
		public Nullable<Int32> PVDDLSix { get; set; }  
 
		public String PVDDL4Code { get; set; }  
 
		public String PVDDL5Code { get; set; }  
 
		public String PVDDL6Code { get; set; } 
    }
}


