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
    public class EditSleTaxesCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 SleTaxId { get; set; }  
 
		public String SleTaxName { get; set; }  
 
		public Int32 STTaxType { get; set; }  
 
		public Int32 STCalcType { get; set; }  
 
		public Int32 STOprType { get; set; }  
 
		public Nullable<Int32> STPriority { get; set; }  
 
		public Nullable<Int32> STPrintPrv { get; set; }  
 
		public Nullable<Int32> STForce { get; set; }  
 
		public Nullable<Int32> STValType { get; set; }  
 
		public Nullable<Int32> STPrionType { get; set; }  
 
		public Nullable<Int32> STMethodType { get; set; }  
 
		public String STSLRef { get; set; }  
 
		public Nullable<Int32> STDL4Type { get; set; }  
 
		public String STDL4Code { get; set; }  
 
		public Nullable<Int32> STDL5Type { get; set; }  
 
		public String STDL5Code { get; set; }  
 
		public Nullable<Int32> STDL6Type { get; set; }  
 
		public String STDL6Code { get; set; }  
 
		public Nullable<Int32> STEffElmnt { get; set; } 

        public void Validate()
        {
            new EditSleTaxesCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
