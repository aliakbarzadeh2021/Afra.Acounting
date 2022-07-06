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
    public class AddPartFormulaCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PartFormulaId { get; set; }  
 
		public Int32 PFProductRef { get; set; }  
 
		public Nullable<Int32> PFType { get; set; }  
 
		public String PFTitle { get; set; }  
 
		public DateTime PFDate { get; set; }  
 
		public Nullable<Int32> PFCostPeriod { get; set; }  
 
		public Nullable<Int32> PFCostCenter { get; set; }  
 
		public Nullable<Int32> PFStep { get; set; }  
 
		public Double PFQty { get; set; }  
 
		public Nullable<Int32> PFParent { get; set; }  
 
		public Nullable<Int32> PFHrmTime { get; set; }  
 
		public Nullable<Int32> PFHrmCnt { get; set; }  
 
		public Nullable<Int32> PFCstTime { get; set; } 

        public void Validate()
        {
            new AddPartFormulaCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
