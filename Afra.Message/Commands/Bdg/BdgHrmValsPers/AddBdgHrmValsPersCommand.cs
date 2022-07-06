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
    public class AddBdgHrmValsPersCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 BdgHrmValsPersId { get; set; }  
 
		public Int32 BHVPParentRef { get; set; }  
 
		public String BHVPFullName { get; set; }  
 
		public Double BHVPAmount { get; set; }  
 
		public Nullable<Int32> BHVPCurRef { get; set; } 

        public void Validate()
        {
            new AddBdgHrmValsPersCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
