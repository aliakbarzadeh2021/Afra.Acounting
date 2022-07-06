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
    public class EditGnrSysFormObjectsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 SysFormObjId { get; set; }  
 
		public Int32 SysFormRef { get; set; }  
 
		public String SFOName { get; set; }  
 
		public String SFOTitle { get; set; }  
 
		public String SFType { get; set; }  
 
		public Nullable<Boolean> SFIsMainField { get; set; }  
 
		public String SFOFldName { get; set; } 

        public void Validate()
        {
            new EditGnrSysFormObjectsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
