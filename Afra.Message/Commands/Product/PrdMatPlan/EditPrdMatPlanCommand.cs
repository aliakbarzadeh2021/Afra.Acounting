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
    public class EditPrdMatPlanCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PrdMatPlanId { get; set; }  
 
		public Int32 PMPMatRef { get; set; }  
 
		public Nullable<Int32> PMPFixTime { get; set; }  
 
		public Nullable<Int32> PMPVarTime { get; set; }  
 
		public Int32 PMPPlanType { get; set; }  
 
		public Nullable<Double> PMPPlanQty { get; set; } 

        public void Validate()
        {
            new EditPrdMatPlanCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
