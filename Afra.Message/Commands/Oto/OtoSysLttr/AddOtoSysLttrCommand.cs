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
    public class AddOtoSysLttrCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 OtoSysLtrId { get; set; }  
 
		public Int32 OSLUserRef { get; set; }  
 
		public DateTime OSLCreateDate { get; set; }  
 
		public Int32 OSLType { get; set; }  
 
		public Nullable<Int32> OSLRefId { get; set; }  
 
		public Byte[] OSLFileObj { get; set; }  
 
		public String OSLSignInf { get; set; }  
 
		public String OSLOthInf { get; set; } 

        public void Validate()
        {
            new AddOtoSysLttrCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
