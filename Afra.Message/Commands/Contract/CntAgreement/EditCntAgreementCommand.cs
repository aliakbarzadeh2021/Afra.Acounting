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
    public class EditCntAgreementCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CntAgrmntId { get; set; }  
 
		public String CAgNum { get; set; }  
 
		public DateTime CAgDate { get; set; }  
 
		public String CAgDescr { get; set; }  
 
		public Int32 CAgMasterRef { get; set; }  
 
		public Nullable<Int32> CAgAmntSit { get; set; }  
 
		public Nullable<Double> CAgAmount { get; set; }  
 
		public String CAgDur { get; set; }  
 
		public Nullable<Double> CAgRatio { get; set; }  
 
		public Nullable<Int32> CAgAccPrdRef { get; set; } 

        public void Validate()
        {
            new EditCntAgreementCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
