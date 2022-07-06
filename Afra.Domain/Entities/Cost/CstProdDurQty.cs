using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class CstProdDurQty : BaseEntity
    {
          
 
		public Int32 CstProdDurQtyId { get; set; }  
 
		public Nullable<Int32> CPDQType { get; set; }  
 
		public Nullable<Int32> CPDQPartRef { get; set; }  
 
		public Nullable<Int32> CPDQPeriodId { get; set; }  
 
		public Nullable<Double> CPDQQty { get; set; }  
 
		public Nullable<Double> CPDQFullPrc { get; set; }  
 
		public Nullable<Double> CPDQHrmAmount { get; set; }  
 
		public Nullable<Double> CPDQCostAmount { get; set; } 
    }
}


