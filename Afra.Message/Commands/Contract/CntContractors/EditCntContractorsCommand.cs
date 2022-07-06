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
    public class EditCntContractorsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CntContrId { get; set; }  
 
		public Int32 CCCrsRef { get; set; }  
 
		public String CCActType { get; set; }  
 
		public String CCFileNo { get; set; }  
 
		public String CCPersiutNo { get; set; }  
 
		public String CCDirectorName { get; set; }  
 
		public String CCRespName { get; set; }  
 
		public String CCBankInf { get; set; }  
 
		public String CCAccountNo { get; set; }  
 
		public String CCECode { get; set; }  
 
		public DateTime CCDutyDate { get; set; }  
 
		public String CCDutyNum { get; set; }  
 
		public String CCSLRef { get; set; } 

        public void Validate()
        {
            new EditCntContractorsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
