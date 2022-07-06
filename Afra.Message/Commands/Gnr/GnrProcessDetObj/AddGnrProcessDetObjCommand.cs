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
    public class AddGnrProcessDetObjCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 GPDOHdrRef { get; set; }  
 
		public Int32 GPDOItmRef { get; set; }  
 
		public Nullable<Int32> GPDOVal { get; set; }  
 
		public String GPDOCond { get; set; } 

        public void Validate()
        {
            new AddGnrProcessDetObjCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
