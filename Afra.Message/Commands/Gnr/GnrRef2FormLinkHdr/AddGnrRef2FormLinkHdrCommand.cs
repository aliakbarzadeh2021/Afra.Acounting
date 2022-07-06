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
    public class AddGnrRef2FormLinkHdrCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 LinkRefHdrId { get; set; }  
 
		public String LRHTitle { get; set; }  
 
		public Int32 LRHSysFormRef { get; set; }  
 
		public Int32 LRHRefFormRef { get; set; }  
 
		public Nullable<Int32> LRHVchType { get; set; }  
 
		public String LRHRefQryCond { get; set; } 

        public void Validate()
        {
            new AddGnrRef2FormLinkHdrCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
