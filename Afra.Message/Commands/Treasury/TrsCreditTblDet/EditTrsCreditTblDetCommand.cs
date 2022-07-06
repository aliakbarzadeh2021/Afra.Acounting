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
    public class EditTrsCreditTblDetCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 TCTDHdrRef { get; set; }  
 
		public Double TCTDFVal { get; set; }  
 
		public Nullable<Double> TCTDTVal { get; set; }  
 
		public Nullable<Double> TCTDDirect { get; set; }  
 
		public Nullable<Double> TCTDInDirect { get; set; } 

        public void Validate()
        {
            new EditTrsCreditTblDetCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
