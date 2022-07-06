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
    public class EditPrdPOrdItmDetCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PPOIDItmRef { get; set; }  
 
		public Int32 PPOIDPartRef { get; set; }  
 
		public Nullable<Int32> PPOIDFrmlRef { get; set; }  
 
		public Nullable<Int32> PPOIDLev { get; set; }  
 
		public Nullable<Double> PPOIDQty { get; set; } 

        public void Validate()
        {
            new EditPrdPOrdItmDetCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
