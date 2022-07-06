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
    public class EditBdgTaxesCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 BdgTaxId { get; set; }  
 
		public String BdgTaxName { get; set; }  
 
		public Int32 BTTaxType { get; set; }  
 
		public Int32 BTOprType { get; set; }  
 
		public String BTSLRef { get; set; }  
 
		public String BTDL4Code { get; set; }  
 
		public String BTDL5Code { get; set; }  
 
		public String BTDL6Code { get; set; } 

        public void Validate()
        {
            new EditBdgTaxesCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
