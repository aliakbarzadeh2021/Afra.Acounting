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
    public class EditCstProductPackDetCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CstProdPackDetId { get; set; }  
 
		public Nullable<Int32> CPPDHdrRef { get; set; }  
 
		public Nullable<Int32> CPPDPartRef { get; set; }  
 
		public Nullable<Double> CPPDQty { get; set; }  
 
		public Nullable<Double> CPPDWast { get; set; } 

        public void Validate()
        {
            new EditCstProductPackDetCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
