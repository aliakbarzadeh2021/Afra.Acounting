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
    public class EditBdgContAccCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 BdgContAccId { get; set; }  
 
		public Int32 BCAContRef { get; set; }  
 
		public String BCASLCode { get; set; }  
 
		public Double BCAAmount { get; set; } 

        public void Validate()
        {
            new EditBdgContAccCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
