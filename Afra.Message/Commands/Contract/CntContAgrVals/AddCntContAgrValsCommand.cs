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
    public class AddCntContAgrValsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CntContAgValId { get; set; }  
 
		public Int32 CCAVFldRef { get; set; }  
 
		public Int32 CCAVBaseItm { get; set; }  
 
		public Nullable<Double> CCAVAmount { get; set; } 

        public void Validate()
        {
            new AddCntContAgrValsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
