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
    public class EditCntContTextCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CntContTextId { get; set; }  
 
		public Int32 CCTContRef { get; set; }  
 
		public Nullable<Int32> CCTRefId { get; set; }  
 
		public String CCTDescr { get; set; } 

        public void Validate()
        {
            new EditCntContTextCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
