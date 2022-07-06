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
    public class EditCntSrvItemsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CntSrvItemId { get; set; }  
 
		public String CSITitle { get; set; }  
 
		public String CSISLRef { get; set; } 

        public void Validate()
        {
            new EditCntSrvItemsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
