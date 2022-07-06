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
    public class AddCmrPreFactHdrCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CmrPreFactHdrId { get; set; }  
 
		public Int32 CPFHNum { get; set; }  
 
		public Nullable<Int32> CPFHLocalNum { get; set; }  
 
		public Nullable<Int32> CPFHSellerRef { get; set; }  
 
		public DateTime CPFHDate { get; set; }  
 
		public Nullable<Int32> CPFHOrdRef { get; set; }  
 
		public Nullable<Int32> CPFHCurRef { get; set; }  
 
		public Nullable<Double> CPFHCurRate { get; set; }  
 
		public String CPFHDescr { get; set; }  
 
		public Nullable<Int32> Creator { get; set; }  
 
		public Nullable<Int32> Confimer { get; set; }  
 
		public Nullable<Int32> CPFHState { get; set; }  
 
		public Nullable<Int32> CAccPrdRef { get; set; } 

        public void Validate()
        {
            new AddCmrPreFactHdrCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
