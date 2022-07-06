using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class OtoFlow : BaseEntity
    {
          
 
		public Int32 OtoFlowId { get; set; }  
 
		public Int32 OFRefType { get; set; }  
 
		public Int32 OFRefId { get; set; }  
 
		public Nullable<Int32> OFFormRef { get; set; }  
 
		public DateTime OFSndDate { get; set; }  
 
		public DateTime OFRcvDate { get; set; }  
 
		public DateTime OFEndDate { get; set; }  
 
		public Int32 OFFromUser { get; set; }  
 
		public Int32 OFToUser { get; set; }  
 
		public String OFSendDescr { get; set; }  
 
		public String OFRcvDescr { get; set; }  
 
		public Nullable<Int32> OFEnded { get; set; }  
 
		public Nullable<Int32> WorkFlowStepRef { get; set; }  
 
		public Nullable<Int32> OFKind { get; set; }  
 
		public Nullable<Int32> OFUrgency { get; set; }  
 
		public DateTime OFFollowDate { get; set; }  
 
		public Nullable<Int32> OFFollowDur { get; set; }  
 
		public Nullable<Int32> OFIsLast { get; set; }  
 
		public Nullable<Int32> OFFileRef { get; set; }  
 
		public Nullable<Int32> OFWithAlarm { get; set; } 
    }
}


