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
    public class EditSleSrvItmCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 SleSrvItmId { get; set; }  
 
		public Nullable<Int32> SleSrvHdrRef { get; set; }  
 
		public Nullable<Int32> SSISeq { get; set; }  
 
		public Int32 SSIServiceRef { get; set; }  
 
		public Nullable<Int32> SSIUnitRef { get; set; }  
 
		public Double SSIMainQty { get; set; }  
 
		public Double SSIAmount { get; set; }  
 
		public String SSIDescr { get; set; }  
 
		public Nullable<Double> SSICurVal { get; set; }  
 
		public Nullable<Int32> SSIRefId { get; set; }  
 
		public Nullable<Int32> SSIRefType { get; set; } 

        public void Validate()
        {
            new EditSleSrvItmCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
