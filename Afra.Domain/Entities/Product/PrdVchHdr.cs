using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class PrdVchHdr : BaseEntity
    {
          
 
		public Int32 PrdVchHdrId { get; set; }  
 
		public Int32 PVHNum { get; set; }  
 
		public Nullable<Int32> PVHLocalNum { get; set; }  
 
		public DateTime PVHDate { get; set; }  
 
		public String PVHDescr { get; set; }  
 
		public Int32 PVHType { get; set; }  
 
		public Nullable<Int32> PVHStockRef { get; set; }  
 
		public Nullable<Int32> PVHVchState { get; set; }  
 
		public String PVHDLRef { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public Nullable<Int32> Confimer { get; set; }  
 
		public Nullable<Int32> PVHState { get; set; }  
 
		public Nullable<Int32> PAccPrdRef { get; set; } 
    }
}


