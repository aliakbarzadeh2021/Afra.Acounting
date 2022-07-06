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
    public class EditAddressCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 AddressId { get; set; }  
 
		public Int32 AdCrsRef { get; set; }  
 
		public Nullable<Int32> AdGeoRef { get; set; }  
 
		public String AdDescr { get; set; }  
 
		public String AdPhone1 { get; set; }  
 
		public String AdPhone2 { get; set; }  
 
		public String AdMobile { get; set; }  
 
		public String AdFax { get; set; }  
 
		public String AdPostCode { get; set; }  
 
		public String AdEMail { get; set; } 

        public void Validate()
        {
            new EditAddressCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
