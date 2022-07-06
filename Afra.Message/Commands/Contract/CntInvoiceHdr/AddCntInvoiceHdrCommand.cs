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
    public class AddCntInvoiceHdrCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CntInvoiceHdrId { get; set; }  
 
		public Int32 CIHType { get; set; }  
 
		public Int32 CIHExpAcntRef { get; set; }  
 
		public DateTime CIHDate { get; set; }  
 
		public Int32 CIHNum { get; set; }  
 
		public Int32 CIHCreator { get; set; }  
 
		public String CIHDescr { get; set; } 

        public void Validate()
        {
            new AddCntInvoiceHdrCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
