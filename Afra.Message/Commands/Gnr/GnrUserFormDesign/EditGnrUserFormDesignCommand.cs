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
    public class EditGnrUserFormDesignCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 GUFDFormRef { get; set; }  
 
		public Int32 GUFDFieldRef { get; set; }  
 
		public Int32 GUFDPropRef { get; set; }  
 
		public Nullable<Int32> GUFDValue { get; set; }  
 
		public String GUFDFieldParent { get; set; } 

        public void Validate()
        {
            new EditGnrUserFormDesignCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
