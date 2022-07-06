using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class CmrPreFactHdr : BaseEntity
    {
          
 
		public Int32 CmrPreFactHdrId { get; set; }  
 
		public Int32 CPFHNum { get; set; }  
 
		public Nullable<Int32> CPFHLocalNum { get; set; }  
 
		public Nullable<Int32> CPFHSellerRef { get; set; }  
 
		public DateTime CPFHDate { get; set; }  
 
		public Nullable<Int32> CPFHOrdRef { get; set; }  
 
		public Nullable<Int32> CPFHCurRef { get; set; }  
 
		public Nullable<Double> CPFHCurRate { get; set; }  
 
		public String CPFHDescr { get; set; }  
 
		public Nullable<Int32> Creator { get; set; }  
 
		public Nullable<Int32> Confimer { get; set; }  
 
		public Nullable<Int32> CPFHState { get; set; }  
 
		public Nullable<Int32> CAccPrdRef { get; set; } 
    }
}


