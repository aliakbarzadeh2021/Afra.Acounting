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
    public class AddGnrSysLogsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 AsmLogId { get; set; }  
 
		public String LogTableName { get; set; }  
 
		public Nullable<Int32> LogOprType { get; set; }  
 
		public Nullable<Int32> LogParentId { get; set; }  
 
		public Nullable<Int32> LogUserRef { get; set; }  
 
		public String LogDate { get; set; }  
 
		public String LogDescr { get; set; }  
 
		public String UserDescr { get; set; } 

        public void Validate()
        {
            new AddGnrSysLogsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
