using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class TrsFundBillHdr : BaseEntity
    {
          
 
		public Int32 TrsFundBillHdrId { get; set; }  
 
		public Int32 TFBHFundRef { get; set; }  
 
		public Int32 TFBHNum { get; set; }  
 
		public Nullable<Int32> TFBHLocalNum { get; set; }  
 
		public DateTime TFBHDate { get; set; }  
 
		public String TFBHDescr { get; set; }  
 
		public Nullable<Int32> Creator { get; set; }  
 
		public Nullable<Int32> Confimer { get; set; }  
 
		public Nullable<Int32> TFBHState { get; set; }  
 
		public Nullable<Int32> TBAccPrdRef { get; set; }  
 
		public Nullable<Int32> TFBTrans { get; set; }  
 
		public Nullable<Int32> TFBHCreator { get; set; }  
 
		public Nullable<Int32> TFBHSit { get; set; } 
    }
}


