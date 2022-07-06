using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class OtoLettersDto
    {
          
 
		public Int32 OtoLettersId { get; set; }  
 
		public Int32 OLType { get; set; }  
 
		public Nullable<Int32> OLCompRef { get; set; }  
 
		public Nullable<Int32> OLCrsRef { get; set; }  
 
		public String OLOthCrsName { get; set; }  
 
		public Nullable<Int32> OLIndRef { get; set; }  
 
		public String OLIndNo { get; set; }  
 
		public String OLSubject { get; set; }  
 
		public String OLDescr { get; set; }  
 
		public DateTime OLCreateDate { get; set; }  
 
		public String OLNumber { get; set; }  
 
		public DateTime OLDate { get; set; }  
 
		public String OLRcptNo { get; set; }  
 
		public DateTime OLRcptDate { get; set; }  
 
		public Nullable<Int32> OLUserRef { get; set; }  
 
		public Nullable<Int32> OLFileRef { get; set; }  
 
		public Nullable<Int32> OLCtgry { get; set; }  
 
		public Nullable<Int32> OLState { get; set; }  
 
		public String OLSignInf { get; set; }  
 
		public Nullable<Int32> OLConfirmer { get; set; }  
 
		public Nullable<Int32> OLApprover { get; set; } 
    }
}


