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
    public class EditHrmStatTypesCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 HrmStatTypeId { get; set; }  
 
		public String HSTDescr { get; set; }  
 
		public String HSTKind { get; set; }  
 
		public String HSTRole { get; set; }  
 
		public String HSTExElmnt { get; set; } 

        public void Validate()
        {
            new EditHrmStatTypesCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
