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
    public class AddCntAmntCurInfCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CntAmntCurInfId { get; set; }  
 
		public Int32 CACIBaseType { get; set; }  
 
		public Int32 CACIBaseRef { get; set; }  
 
		public Int32 CACICurRef { get; set; }  
 
		public Double CACIAmount { get; set; } 

        public void Validate()
        {
            new AddCntAmntCurInfCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
