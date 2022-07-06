using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class Parts : BaseEntity
    {
          
 
		public Int32 PartId { get; set; }  
 
		public String PartCode { get; set; }  
 
		public String PartName { get; set; }  
 
		public Int32 UnitRef { get; set; }  
 
		public Nullable<Int32> InvCtgryRef { get; set; }  
 
		public String PartECode { get; set; }  
 
		public String PartOInf { get; set; }  
 
		public String PartType { get; set; }  
 
		public String PBarcode { get; set; }  
 
		public Nullable<Int32> SleCtgryRef { get; set; }  
 
		public String PDLRef { get; set; }  
 
		public Nullable<Int32> PartSit { get; set; }  
 
		public Nullable<Int32> ProdType { get; set; } 
    }
}


