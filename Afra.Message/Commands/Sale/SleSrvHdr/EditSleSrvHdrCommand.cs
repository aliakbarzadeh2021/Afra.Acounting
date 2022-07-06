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
    public class EditSleSrvHdrCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 SleSrvHdrID { get; set; }  
 
		public Int32 SSHNum { get; set; }  
 
		public Nullable<Int32> SSHLocalNum { get; set; }  
 
		public DateTime SSHDate { get; set; }  
 
		public String SSHDescr { get; set; }  
 
		public Int32 SSHBranchRef { get; set; }  
 
		public Nullable<Int32> SSHPlaceRef { get; set; }  
 
		public Int32 SSHCstmrRef { get; set; }  
 
		public Nullable<Int32> SSHBrokerRef { get; set; }  
 
		public Nullable<Int32> SSHSaleType { get; set; }  
 
		public Nullable<Int32> Creator { get; set; }  
 
		public Nullable<Int32> Confimer { get; set; }  
 
		public Nullable<Int32> SSHState { get; set; }  
 
		public Nullable<Int32> SrAccPrdRef { get; set; }  
 
		public Nullable<Int32> SSHCurRef { get; set; }  
 
		public Nullable<Double> SSHCurRate { get; set; }  
 
		public String SSHCstmrECode { get; set; }  
 
		public String SSHCstmrNatCode { get; set; }  
 
		public String SSHCstmrRegNo { get; set; }  
 
		public String SSHCstmrName { get; set; }  
 
		public String SSHCstmrTel { get; set; }  
 
		public String SSHCstmrAddr { get; set; }  
 
		public String SSHCstmrPostCode { get; set; }  
 
		public Nullable<Int32> SSHRefId { get; set; }  
 
		public Nullable<Int32> SSHRefType { get; set; } 

        public void Validate()
        {
            new EditSleSrvHdrCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
