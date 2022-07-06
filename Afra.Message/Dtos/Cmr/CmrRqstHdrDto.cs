using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class CmrRqstHdrDto
    {
          
 
		public Int32 CmrRqstHdrId { get; set; }  
 
		public Int32 CRHNum { get; set; }  
 
		public Nullable<Int32> CRHLocalNum { get; set; }  
 
		public Int32 CRHType { get; set; }  
 
		public DateTime CRHDate { get; set; }  
 
		public String CRHDLRef { get; set; }  
 
		public String CRHDescr { get; set; }  
 
		public Nullable<Int32> Creator { get; set; }  
 
		public Nullable<Int32> Confimer { get; set; }  
 
		public Nullable<Int32> CRHState { get; set; }  
 
		public Nullable<Int32> CAccPrdRef { get; set; }  
 
		public Nullable<Int32> CRHRefID { get; set; }  
 
		public Nullable<Int32> CRHRefType { get; set; } 
    }
}


