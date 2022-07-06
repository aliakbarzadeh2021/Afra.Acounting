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
    public class EditTrsRqstItmCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 TrsRqstItmId { get; set; }  
 
		public Nullable<Int32> TrsRqstHdrRef { get; set; }  
 
		public Nullable<Int32> TRICashFactRef { get; set; }  
 
		public Nullable<Int32> TRIBankAccRef { get; set; }  
 
		public Nullable<Int32> TRICashRef { get; set; }  
 
		public String TRIDLRef { get; set; }  
 
		public Nullable<Int32> TRISeq { get; set; }  
 
		public String TRIDescr { get; set; }  
 
		public DateTime TRIDate { get; set; }  
 
		public Double TRIQty { get; set; }  
 
		public String TRIDLFive { get; set; }  
 
		public String TRIDLSix { get; set; } 

        public void Validate()
        {
            new EditTrsRqstItmCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
