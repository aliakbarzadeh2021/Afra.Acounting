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
    public class AddPrdStopItmCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PrdStopItmId { get; set; }  
 
		public Int32 PrdStopRef { get; set; }  
 
		public Int32 PSISeq { get; set; }  
 
		public Int32 PSIWStation { get; set; }  
 
		public Int32 PSIMashRef { get; set; }  
 
		public DateTime PSIFTime { get; set; }  
 
		public DateTime PSITTime { get; set; }  
 
		public String PSIDescr { get; set; } 

        public void Validate()
        {
            new AddPrdStopItmCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
