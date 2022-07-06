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
    public class EditHrmPersCompAsignCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 HrmPersCompAsgnId { get; set; }  
 
		public Nullable<Int32> HPCAEmpStatRef { get; set; }  
 
		public Nullable<Int32> HPCACompRef { get; set; }  
 
		public Nullable<Int32> HPCACompBrnRef { get; set; }  
 
		public Nullable<Int32> HPCAIsRel { get; set; }  
 
		public String HPCAPersId { get; set; } 

        public void Validate()
        {
            new EditHrmPersCompAsignCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
