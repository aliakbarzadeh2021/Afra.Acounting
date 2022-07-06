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
    public class EditCntFormValsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CntFormValsId { get; set; }  
 
		public Int32 CFVType { get; set; }  
 
		public Int32 CFVBaseId { get; set; }  
 
		public Int32 CFVFieldRef { get; set; }  
 
		public Nullable<Double> CFVAmount { get; set; } 

        public void Validate()
        {
            new EditCntFormValsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
