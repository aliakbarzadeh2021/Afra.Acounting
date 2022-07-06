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
    public class AddPmiReqPartCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PMIReqPartId { get; set; }  
 
		public Int32 PRPPrjRef { get; set; }  
 
		public Int32 PRPPartRef { get; set; }  
 
		public DateTime PRPDate { get; set; }  
 
		public Nullable<Double> PRPQty { get; set; }  
 
		public Nullable<Int32> PRPCreator { get; set; } 

        public void Validate()
        {
            new AddPmiReqPartCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
