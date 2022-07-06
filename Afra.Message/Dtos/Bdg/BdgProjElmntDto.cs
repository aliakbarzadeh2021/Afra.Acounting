using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class BdgProjElmntDto
    {
          
 
		public Int32 BdgProjElmntId { get; set; }  
 
		public String BPETitle { get; set; }  
 
		public Int32 BPEGrp { get; set; }  
 
		public Int32 BPEParent { get; set; }  
 
		public Int32 BPEUnit { get; set; }  
 
		public Nullable<Int32> BPECurRef { get; set; }  
 
		public Nullable<Double> BPERate { get; set; }  
 
		public Int32 BPEPeriodId { get; set; }  
 
		public String BPESLRef { get; set; } 
    }
}


