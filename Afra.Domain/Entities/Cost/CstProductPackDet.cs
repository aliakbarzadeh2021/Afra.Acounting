using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class CstProductPackDet : BaseEntity
    {
          
 
		public Int32 CstProdPackDetId { get; set; }  
 
		public Nullable<Int32> CPPDHdrRef { get; set; }  
 
		public Nullable<Int32> CPPDPartRef { get; set; }  
 
		public Nullable<Double> CPPDQty { get; set; }  
 
		public Nullable<Double> CPPDWast { get; set; } 
    }
}


