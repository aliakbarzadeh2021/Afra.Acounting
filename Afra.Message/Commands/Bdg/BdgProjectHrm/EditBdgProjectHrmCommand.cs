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
    public class EditBdgProjectHrmCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 BdgProjectHrmId { get; set; }  
 
		public Int32 BPHHdrRef { get; set; }  
 
		public String BPHDescr { get; set; }  
 
		public Nullable<Int32> BPHQty { get; set; }  
 
		public Nullable<Int32> BPHDay { get; set; }  
 
		public Nullable<Double> BPHCost { get; set; } 

        public void Validate()
        {
            new EditBdgProjectHrmCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
