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
    public class EditsysdiagramsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public String name { get; set; }  
 
		public Int32 principal_id { get; set; }  
 
		public Int32 diagram_id { get; set; }  
 
		public Nullable<Int32> version { get; set; }  
 
		public Byte[] definition { get; set; } 

        public void Validate()
        {
            new EditsysdiagramsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
