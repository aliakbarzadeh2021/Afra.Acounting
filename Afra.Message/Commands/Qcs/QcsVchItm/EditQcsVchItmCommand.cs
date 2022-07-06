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
    public class EditQcsVchItmCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 QcsVchItmId { get; set; }  
 
		public Int32 QcsVchHdrRef { get; set; }  
 
		public Int32 QVITestItmRef { get; set; }  
 
		public String QVIRes { get; set; }  
 
		public String QVIResDescr { get; set; }  
 
		public Nullable<Int32> QVIOK { get; set; } 

        public void Validate()
        {
            new EditQcsVchItmCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
