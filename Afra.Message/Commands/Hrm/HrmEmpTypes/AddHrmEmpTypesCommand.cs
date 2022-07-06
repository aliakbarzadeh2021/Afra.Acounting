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
    public class AddHrmEmpTypesCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 EmpTypeId { get; set; }  
 
		public String EmpTypeTitle { get; set; }  
 
		public Nullable<Int32> EmpTypeCode { get; set; } 

        public void Validate()
        {
            new AddHrmEmpTypesCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
