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
    public class EditPrdStopCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PrdStopId { get; set; }  
 
		public Int32 PSNum { get; set; }  
 
		public DateTime PSDate { get; set; }  
 
		public String PSDescr { get; set; }  
 
		public Int32 PSYear { get; set; }  
 
		public Nullable<Int32> PSState { get; set; }  
 
		public Nullable<Int32> Creator { get; set; } 

        public void Validate()
        {
            new EditPrdStopCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
