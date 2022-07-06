using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class InvFormHdrDto
    {
          
 
		public Int32 InvFormHdrId { get; set; }  
 
		public Int32 IFHNum { get; set; }  
 
		public Nullable<Int32> IFHLocalNum { get; set; }  
 
		public DateTime IFHDate { get; set; }  
 
		public String IFHDescr { get; set; }  
 
		public Int32 IFHType { get; set; }  
 
		public String IFHDLRef { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public Nullable<Int32> Confimer { get; set; }  
 
		public Nullable<Int32> IFHState { get; set; }  
 
		public Nullable<Int32> IFAccPrdRef { get; set; }  
 
		public Nullable<Int32> IFHRefID { get; set; }  
 
		public Nullable<Int32> IFHRefType { get; set; } 
    }
}


