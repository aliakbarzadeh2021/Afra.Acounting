using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class CmrPreFactItm : BaseEntity
    {
          
 
		public Int32 CmrPreFactItmId { get; set; }  
 
		public Int32 CPFISeq { get; set; }  
 
		public Int32 CmrPreFactHdrRef { get; set; }  
 
		public Int32 CPFIOrdRef { get; set; }  
 
		public Nullable<Double> CPFIOthQty { get; set; }  
 
		public Nullable<Double> CPFIMainQty { get; set; }  
 
		public Nullable<Double> CPFIAmount { get; set; }  
 
		public Nullable<Double> CPFIIncAmnt { get; set; }  
 
		public Nullable<Double> CPFIDecAmnt { get; set; }  
 
		public String CPFIDescr { get; set; }  
 
		public Nullable<Int32> CPFIStatus { get; set; } 
    }
}


