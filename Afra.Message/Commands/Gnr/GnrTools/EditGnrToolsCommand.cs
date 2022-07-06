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
    public class EditGnrToolsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 GnrToolsId { get; set; }  
 
		public String GTTitle { get; set; }  
 
		public String GTSysRef { get; set; }  
 
		public String GTListQry { get; set; }  
 
		public String GTOprQry { get; set; } 

        public void Validate()
        {
            new EditGnrToolsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
