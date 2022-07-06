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
    public class AddTrsFacilitiesDetCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 TrsFacilitiesDetId { get; set; }  
 
		public Int32 TFDFacRef { get; set; }  
 
		public Int32 TFDNum { get; set; }  
 
		public String TFDPaySerial { get; set; }  
 
		public DateTime TFDDate { get; set; }  
 
		public Double TFDInstAmnt { get; set; }  
 
		public Nullable<Double> TFDShareAmnt { get; set; }  
 
		public Nullable<Double> TFDTaxAmnt { get; set; }  
 
		public Nullable<Double> TFDDutyAmnt { get; set; }  
 
		public Nullable<Double> TFDLateAmnt { get; set; }  
 
		public Nullable<Double> TFDPayAmnt { get; set; }  
 
		public String TFDDescr { get; set; }  
 
		public DateTime TFDPayDate { get; set; }  
 
		public Nullable<Int32> TFDAccPrdRef { get; set; } 

        public void Validate()
        {
            new AddTrsFacilitiesDetCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
