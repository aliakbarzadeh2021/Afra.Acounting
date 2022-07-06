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
    public class EditCntContAmntChngCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CntContAmntChngId { get; set; }  
 
		public Int32 CCACContRef { get; set; }  
 
		public Int32 CCACType { get; set; }  
 
		public DateTime CCACDate { get; set; }  
 
		public String CCACDescr { get; set; }  
 
		public Double CCACVal { get; set; } 

        public void Validate()
        {
            new EditCntContAmntChngCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
