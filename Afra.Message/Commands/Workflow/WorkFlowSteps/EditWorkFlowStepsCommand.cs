using Afra.Message.Base;
using Afra.Message.Extentions;
using Afra.Message.Validators;
using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Commands
{
    /// <summary>
    ///  
    /// </summary>
    public class EditWorkFlowStepsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
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

        public void Validate()
        {
            new EditWorkFlowStepsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
