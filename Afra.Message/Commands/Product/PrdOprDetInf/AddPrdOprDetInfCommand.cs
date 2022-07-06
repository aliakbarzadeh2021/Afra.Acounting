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
    public class AddPrdOprDetInfCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PODIItmRef { get; set; }  
 
		public Int32 PODIType { get; set; }  
 
		public String PODITitle { get; set; }  
 
		public String PODIDescr { get; set; } 

        public void Validate()
        {
            new AddPrdOprDetInfCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
