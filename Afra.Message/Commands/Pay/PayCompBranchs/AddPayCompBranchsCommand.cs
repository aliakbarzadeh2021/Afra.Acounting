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
    public class AddPayCompBranchsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PayCompBranchId { get; set; }  
 
		public Int32 PCBCompRef { get; set; }  
 
		public Int32 PCBCrspndRef { get; set; }  
 
		public String PCBCompID { get; set; }  
 
		public Nullable<Int32> PCBIsMain { get; set; }  
 
		public String PCBContNum { get; set; } 

        public void Validate()
        {
            new AddPayCompBranchsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
