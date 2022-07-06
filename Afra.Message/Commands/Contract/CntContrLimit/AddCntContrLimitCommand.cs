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
    public class AddCntContrLimitCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CntContrLimitId { get; set; }  
 
		public Int32 CCLContrRef { get; set; }  
 
		public Int32 CCLState { get; set; }  
 
		public DateTime CCLDate { get; set; }  
 
		public String CCLDescr { get; set; } 

        public void Validate()
        {
            new AddCntContrLimitCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
