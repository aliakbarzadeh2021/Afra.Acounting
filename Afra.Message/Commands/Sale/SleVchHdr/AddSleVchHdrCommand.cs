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
    public class AddSleVchHdrCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 SleVchHdrID { get; set; }  
 
		public Int32 SVHNum { get; set; }  
 
		public Nullable<Int32> SVHLocalNum { get; set; }  
 
		public DateTime SVHDate { get; set; }  
 
		public String SVHDescr { get; set; }  
 
		public Int32 SVHBranchRef { get; set; }  
 
		public Nullable<Int32> SVHPlaceRef { get; set; }  
 
		public Nullable<Int32> SVHStockRef { get; set; }  
 
		public Int32 SVHVchType { get; set; }  
 
		public Int32 SVHCstmrRef { get; set; }  
 
		public Nullable<Int32> SVHBrokerRef { get; set; }  
 
		public Nullable<Int32> SVHSaleType { get; set; }  
 
		public Nullable<Int32> Creator { get; set; }  
 
		public Nullable<Int32> Confimer { get; set; }  
 
		public Nullable<Int32> SVHState { get; set; }  
 
		public Nullable<Int32> SAccPrdRef { get; set; }  
 
		public Nullable<Int32> SVHRefID { get; set; }  
 
		public Nullable<Int32> SVHRefType { get; set; }  
 
		public Nullable<Int32> SVHCurRef { get; set; }  
 
		public Nullable<Double> SVHCurRate { get; set; }  
 
		public String SVHDLRef { get; set; }  
 
		public String SVHCstmrECode { get; set; }  
 
		public String SVHCstmrNatCode { get; set; }  
 
		public String SVHCstmrRegNo { get; set; }  
 
		public String SVHCstmrName { get; set; }  
 
		public String SVHCstmrTel { get; set; }  
 
		public String SVHCstmrAddr { get; set; }  
 
		public String SVHCstmrPostCode { get; set; } 

        public void Validate()
        {
            new AddSleVchHdrCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
