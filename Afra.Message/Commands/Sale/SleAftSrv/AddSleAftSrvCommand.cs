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
    public class AddSleAftSrvCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 SleAftSrvId { get; set; }  
 
		public String SASNum { get; set; }  
 
		public DateTime SASDate { get; set; }  
 
		public Int32 SASCstmrRef { get; set; }  
 
		public String SASResp { get; set; }  
 
		public Int32 SASPartRef { get; set; }  
 
		public Int32 SASQty { get; set; }  
 
		public String SASDescr { get; set; }  
 
		public Int32 SASGuaRef { get; set; }  
 
		public Int32 SASPrdRef { get; set; } 

        public void Validate()
        {
            new AddSleAftSrvCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
