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
    public class AddCntFormFieldsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CntFormFieldsId { get; set; }  
 
		public Int32 CFFType { get; set; }  
 
		public String CFFTitle { get; set; }  
 
		public Nullable<Int32> CFFCalcPr { get; set; }  
 
		public Nullable<Int32> CFFFieldOpr { get; set; } 

        public void Validate()
        {
            new AddCntFormFieldsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
