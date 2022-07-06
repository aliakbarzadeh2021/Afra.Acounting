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
    public class AddCmrTransportCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CmrTransportId { get; set; }  
 
		public String CTNum { get; set; }  
 
		public Int32 CTInvoiceRef { get; set; }  
 
		public Int32 CTCompRef { get; set; }  
 
		public DateTime CTDate { get; set; }  
 
		public DateTime CTIssDate { get; set; }  
 
		public DateTime CTStartDate { get; set; }  
 
		public Nullable<Int32> CTTransType { get; set; }  
 
		public Nullable<Int32> CTFromLoc { get; set; }  
 
		public Nullable<Int32> CTToLoc { get; set; }  
 
		public Double CTAmount { get; set; }  
 
		public Nullable<Int32> CTCurRef { get; set; }  
 
		public Nullable<Double> CTCurRate { get; set; } 

        public void Validate()
        {
            new AddCmrTransportCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
