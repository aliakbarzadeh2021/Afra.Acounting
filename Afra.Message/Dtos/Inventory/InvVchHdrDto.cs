using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class InvVchHdrDto
    {
          
 
		public Int32 InvVchHdrId { get; set; }  
 
		public Int32 IVHNum { get; set; }  
 
		public Nullable<Int32> IVHLocalNum { get; set; }  
 
		public DateTime IVHDate { get; set; }  
 
		public String IVHDescr { get; set; }  
 
		public Int32 IVHStockRef { get; set; }  
 
		public Nullable<Int32> IVHOpStkRef { get; set; }  
 
		public Int32 IVHVchType { get; set; }  
 
		public String IVHSLRef { get; set; }  
 
		public String IVHDLRef { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public Nullable<Int32> Confimer { get; set; }  
 
		public Nullable<Int32> IVHState { get; set; }  
 
		public Nullable<Int32> IAccPrdRef { get; set; }  
 
		public Nullable<Int32> IVHRefID { get; set; }  
 
		public Nullable<Int32> IVHRefType { get; set; } 
    }
}


