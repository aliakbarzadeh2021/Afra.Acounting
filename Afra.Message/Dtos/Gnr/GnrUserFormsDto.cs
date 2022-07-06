using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class GnrUserFormsDto
    {
          
 
		public Int32 GnrUsrFrmId { get; set; }  
 
		public String GUFTitle { get; set; }  
 
		public String GUFTableName { get; set; }  
 
		public String GUFLink { get; set; }  
 
		public Nullable<Int32> GUFDesField { get; set; }  
 
		public String GUFFormId { get; set; }  
 
		public Nullable<Int32> GUFCtgryRef { get; set; }  
 
		public Nullable<Int32> GUFFormRelType { get; set; }  
 
		public Nullable<Int32> GUFFormType { get; set; }  
 
		public Nullable<Int32> GUFAutoRefresh { get; set; }  
 
		public Nullable<Int32> GUFNoList { get; set; } 
    }
}


