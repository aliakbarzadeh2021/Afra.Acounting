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
    public class EditCstAccRelInfCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CARPeriodId { get; set; }  
 
		public String CARType { get; set; }  
 
		public String CARSLCode { get; set; }  
 
		public Nullable<Int32> CARDL4Type { get; set; }  
 
		public String CARDL4Code { get; set; }  
 
		public Nullable<Int32> CARDL5Type { get; set; }  
 
		public String CARDL5Code { get; set; }  
 
		public Nullable<Int32> CARDL6Type { get; set; }  
 
		public String CARDL6Code { get; set; } 

        public void Validate()
        {
            new EditCstAccRelInfCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
