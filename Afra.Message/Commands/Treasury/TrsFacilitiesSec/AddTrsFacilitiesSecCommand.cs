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
    public class AddTrsFacilitiesSecCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 TrsFacilitiesSecId { get; set; }  
 
		public Int32 TFSFacRef { get; set; }  
 
		public String TFSDLRef { get; set; }  
 
		public String TFSFullName { get; set; }  
 
		public String TFSNatCode { get; set; }  
 
		public String TFSPhone { get; set; }  
 
		public String TFSMobile { get; set; }  
 
		public String TFSDescr { get; set; } 

        public void Validate()
        {
            new AddTrsFacilitiesSecCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
