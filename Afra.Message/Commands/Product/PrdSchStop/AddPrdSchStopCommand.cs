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
    public class AddPrdSchStopCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PrdSchStopId { get; set; }  
 
		public DateTime PSSFDate { get; set; }  
 
		public DateTime PSSTDate { get; set; }  
 
		public String PSSDescr { get; set; }  
 
		public Int32 PSSYear { get; set; } 

        public void Validate()
        {
            new AddPrdSchStopCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
