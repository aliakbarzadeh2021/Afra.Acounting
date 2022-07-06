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
    public class AddPrdFixStopCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PrdFixStopId { get; set; }  
 
		public DateTime PFSFTime { get; set; }  
 
		public DateTime PFSTTime { get; set; }  
 
		public String PFSDescr { get; set; } 

        public void Validate()
        {
            new AddPrdFixStopCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
