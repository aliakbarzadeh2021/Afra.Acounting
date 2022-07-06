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
    public class EditCmrFactHdrCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CmrFactHdrId { get; set; }  
 
		public Int32 CFHNum { get; set; }  
 
		public Nullable<Int32> CFHLocalNum { get; set; }  
 
		public Nullable<Int32> CFHPOrdRef { get; set; }  
 
		public DateTime CFHDate { get; set; }  
 
		public String CFHDescr { get; set; }  
 
		public Nullable<Int32> Creator { get; set; }  
 
		public Nullable<Int32> Confimer { get; set; }  
 
		public Nullable<Int32> CFHState { get; set; }  
 
		public Nullable<Int32> CAccPrdRef { get; set; }  
 
		public Nullable<Int32> CFHSellerRef { get; set; }  
 
		public Nullable<Int32> CFHCurRef { get; set; }  
 
		public Nullable<Double> CFHCurRate { get; set; }  
 
		public Nullable<Int32> CFHTransType { get; set; } 

        public void Validate()
        {
            new EditCmrFactHdrCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
