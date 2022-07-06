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
    public class EditCntExpAcntValsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CntExpAcntValId { get; set; }  
 
		public Int32 CEAVFldRef { get; set; }  
 
		public Int32 CEAVExpAcntRef { get; set; }  
 
		public Nullable<Double> CEAVAmount { get; set; }  
 
		public Nullable<Int32> CEAVFormulRef { get; set; }  
 
		public Nullable<Double> CEAVCurVal { get; set; } 

        public void Validate()
        {
            new EditCntExpAcntValsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
