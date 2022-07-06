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
    public class EditCmrContItmCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CmrContItmId { get; set; }  
 
		public Int32 CCISeq { get; set; }  
 
		public Int32 CmrContHdrRef { get; set; }  
 
		public Int32 CCIPartRef { get; set; }  
 
		public Nullable<Int32> CCIUnitRef { get; set; }  
 
		public Nullable<Double> CCIMainQty { get; set; }  
 
		public Nullable<Double> CCIRate { get; set; }  
 
		public String CCIDescr { get; set; }  
 
		public Nullable<Int32> CCIStatus { get; set; }  
 
		public Nullable<Int32> CCIRefType { get; set; }  
 
		public Nullable<Int32> CCIRefId { get; set; } 

        public void Validate()
        {
            new EditCmrContItmCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
