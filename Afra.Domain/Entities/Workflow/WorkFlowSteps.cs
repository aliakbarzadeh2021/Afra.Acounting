using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class WorkFlowSteps : BaseEntity
    {
          
 
		public Int32 WorkFlowStepId { get; set; }  
 
		public Int32 WorkFlowRef { get; set; }  
 
		public Int32 WFSInd { get; set; }  
 
		public String WFSTitle { get; set; }  
 
		public Nullable<Int32> WFSUserRef { get; set; }  
 
		public Nullable<Int32> WFWithoutSign { get; set; }  
 
		public Nullable<Int32> WFStepRef { get; set; }  
 
		public Nullable<Int32> WFIsReturn { get; set; }  
 
		public Nullable<Int32> WFParentStep { get; set; }  
 
		public Nullable<Int32> WFOprType { get; set; } 
    }
}


