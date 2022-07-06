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
    public class EditCstProdDurQtyCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CstProdDurQtyId { get; set; }  
 
		public Nullable<Int32> CPDQType { get; set; }  
 
		public Nullable<Int32> CPDQPartRef { get; set; }  
 
		public Nullable<Int32> CPDQPeriodId { get; set; }  
 
		public Nullable<Double> CPDQQty { get; set; }  
 
		public Nullable<Double> CPDQFullPrc { get; set; }  
 
		public Nullable<Double> CPDQHrmAmount { get; set; }  
 
		public Nullable<Double> CPDQCostAmount { get; set; } 

        public void Validate()
        {
            new EditCstProdDurQtyCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
