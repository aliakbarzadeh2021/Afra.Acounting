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
    public class AddGnrAutoTextCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 GnrAutoTextId { get; set; }  
 
		public String GATFormRef { get; set; }  
 
		public String GATObjName { get; set; }  
 
		public String GATText { get; set; } 

        public void Validate()
        {
            new AddGnrAutoTextCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
