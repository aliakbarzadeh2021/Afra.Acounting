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
    public class AddCmrPOrderHdrCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CmrPOrderHdrId { get; set; }  
 
		public Int32 CPOHNum { get; set; }  
 
		public Nullable<Int32> CPOHLocalNum { get; set; }  
 
		public Nullable<Int32> CPOHPreFactRef { get; set; }  
 
		public DateTime CPOHDate { get; set; }  
 
		public String CPOHDescr { get; set; }  
 
		public Nullable<Int32> Creator { get; set; }  
 
		public Nullable<Int32> Confimer { get; set; }  
 
		public Nullable<Int32> CPOHState { get; set; }  
 
		public Nullable<Int32> CAccPrdRef { get; set; }  
 
		public Nullable<Int32> CPOHCurRef { get; set; } 

        public void Validate()
        {
            new AddCmrPOrderHdrCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
