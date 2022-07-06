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
    public class AddCmrTransportDetCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CmrTransportDetId { get; set; }  
 
		public Int32 CTDItmRef { get; set; }  
 
		public Int32 CTDType { get; set; }  
 
		public Nullable<Double> CTDQty { get; set; }  
 
		public Nullable<Double> CTDGross { get; set; }  
 
		public Nullable<Int32> CTDUnitRef { get; set; }  
 
		public Nullable<Double> CTDVolume { get; set; }  
 
		public Nullable<Int32> CTDVolUnitRef { get; set; }  
 
		public String CTDDescr { get; set; } 

        public void Validate()
        {
            new AddCmrTransportDetCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
