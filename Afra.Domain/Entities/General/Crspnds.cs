using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class Crspnds : BaseEntity
    {
          
 
		public Int32 CrspndId { get; set; }  
 
		public String CrspndName { get; set; }  
 
		public String CrsDLRef { get; set; }  
 
		public Int32 CrsType { get; set; }  
 
		public String ECode { get; set; }  
 
		public Nullable<Int32> AcCtgry { get; set; }  
 
		public String RegNo { get; set; }  
 
		public String NatCode { get; set; }  
 
		public String CrsTitle { get; set; } 
    }
}


