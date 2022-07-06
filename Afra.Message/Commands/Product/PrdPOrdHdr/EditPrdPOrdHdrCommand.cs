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
    public class EditPrdPOrdHdrCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PrdPOrdHdrId { get; set; }  
 
		public Int32 PPOHNum { get; set; }  
 
		public DateTime PPOHDate { get; set; }  
 
		public String PPOHDescr { get; set; }  
 
		public Nullable<Int32> Creator { get; set; }  
 
		public Nullable<Int32> Confimer { get; set; }  
 
		public Nullable<Int32> PPOHState { get; set; }  
 
		public Nullable<Int32> PPOHYear { get; set; } 

        public void Validate()
        {
            new EditPrdPOrdHdrCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
