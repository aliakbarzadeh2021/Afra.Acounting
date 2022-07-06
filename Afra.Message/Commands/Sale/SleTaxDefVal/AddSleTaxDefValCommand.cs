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
    public class AddSleTaxDefValCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 SleTaxDefValId { get; set; }  
 
		public Int32 STDVTaxRef { get; set; }  
 
		public Nullable<Int32> STDVBranchRef { get; set; }  
 
		public Nullable<Int32> STDVCstmrRef { get; set; }  
 
		public Nullable<Int32> STDVPartRef { get; set; }  
 
		public Nullable<Int32> STDVPartGrpRef { get; set; }  
 
		public Nullable<Int32> STDVPlaceRef { get; set; }  
 
		public Nullable<Int32> STDVSaleType { get; set; }  
 
		public DateTime STDVDate { get; set; }  
 
		public Double STDVAmount { get; set; }  
 
		public Nullable<Double> STDVFQty { get; set; }  
 
		public Nullable<Double> STDVEQty { get; set; }  
 
		public Nullable<Double> STDVFAmnt { get; set; }  
 
		public Nullable<Double> STDVEAmnt { get; set; }  
 
		public Nullable<Double> STDVDur { get; set; }  
 
		public Nullable<Int32> STDVCstmrGrpRef { get; set; }  
 
		public Nullable<Int32> STDVCalcMethod { get; set; }  
 
		public Nullable<Int32> STDVCalcType { get; set; }  
 
		public DateTime STDVFDate { get; set; }  
 
		public DateTime STDVEDate { get; set; }  
 
		public Nullable<Int32> STDVRangeAll { get; set; }  
 
		public Nullable<Int32> STDVType { get; set; }  
 
		public Nullable<Int32> STDVServiceRef { get; set; }  
 
		public Nullable<Int32> STDVSrvGrpRef { get; set; } 

        public void Validate()
        {
            new AddSleTaxDefValCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
