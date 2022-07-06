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
    public class EditGnrRef2FormLinksItmCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 LinkRefHdrRef { get; set; }  
 
		public Int32 LRSysFormObjRef { get; set; }  
 
		public String LRFieldName { get; set; }  
 
		public Nullable<Int32> LRForceBaseVal { get; set; } 

        public void Validate()
        {
            new EditGnrRef2FormLinksItmCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
