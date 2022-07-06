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
    public class AddCmrPreFactItmCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CmrPreFactItmId { get; set; }  
 
		public Int32 CPFISeq { get; set; }  
 
		public Int32 CmrPreFactHdrRef { get; set; }  
 
		public Int32 CPFIOrdRef { get; set; }  
 
		public Nullable<Double> CPFIOthQty { get; set; }  
 
		public Nullable<Double> CPFIMainQty { get; set; }  
 
		public Nullable<Double> CPFIAmount { get; set; }  
 
		public Nullable<Double> CPFIIncAmnt { get; set; }  
 
		public Nullable<Double> CPFIDecAmnt { get; set; }  
 
		public String CPFIDescr { get; set; }  
 
		public Nullable<Int32> CPFIStatus { get; set; } 

        public void Validate()
        {
            new AddCmrPreFactItmCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
