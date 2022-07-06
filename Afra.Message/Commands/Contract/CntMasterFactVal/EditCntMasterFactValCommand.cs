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
    public class EditCntMasterFactValCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CntMastFactValsId { get; set; }  
 
		public Int32 CMFVFldRef { get; set; }  
 
		public Int32 CMFVFactRef { get; set; }  
 
		public Nullable<Double> CMFVAmount { get; set; }  
 
		public Nullable<Int32> CMFVFormulRef { get; set; }  
 
		public Nullable<Double> CMFVCurVal { get; set; } 

        public void Validate()
        {
            new EditCntMasterFactValCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
