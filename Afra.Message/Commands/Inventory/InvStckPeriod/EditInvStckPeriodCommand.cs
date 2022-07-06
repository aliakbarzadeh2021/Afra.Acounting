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
    public class EditInvStckPeriodCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 InvStckPeriodID { get; set; }  
 
		public String ISPTitle { get; set; }  
 
		public DateTime ISPDate { get; set; }  
 
		public Int32 ISPSCount { get; set; }  
 
		public Nullable<Double> ISPCnt1MinQty { get; set; }  
 
		public Nullable<Double> ISPCnt1MinAmount { get; set; }  
 
		public Nullable<Double> ISPCnt1MinVch { get; set; }  
 
		public Nullable<Int32> ISPList1Cond { get; set; }  
 
		public Nullable<Int32> ISPList2Cond { get; set; }  
 
		public Nullable<Int32> ISPList3Cond { get; set; }  
 
		public Nullable<Int32> ISPAccPrdRef { get; set; }  
 
		public Nullable<Int32> ISPIncVchRef { get; set; }  
 
		public Nullable<Int32> ISPDecVchRef { get; set; } 

        public void Validate()
        {
            new EditInvStckPeriodCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
