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
    public class AddGnrSysTablesCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 GnrSysTableId { get; set; }  
 
		public String GSTName { get; set; }  
 
		public String GSTTitle { get; set; }  
 
		public Nullable<Int32> GSTParent { get; set; }  
 
		public String GSTKeyName { get; set; }  
 
		public String GSTRelKeyName { get; set; }  
 
		public String GSTSystem { get; set; }  
 
		public String GSTQuery { get; set; } 

        public void Validate()
        {
            new AddGnrSysTablesCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
