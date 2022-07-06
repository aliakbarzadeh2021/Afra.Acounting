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
    public class EditGnrUserLogCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 GnrUserLogId { get; set; }  
 
		public Int32 GULUserRef { get; set; }  
 
		public String GULCompName { get; set; }  
 
		public DateTime GULSDate { get; set; }  
 
		public Nullable<DateTime> GULEDate { get; set; }  
 
		public Int32 GULType { get; set; }  
 
		public String GULDescr { get; set; }  
 
		public Nullable<Int32> GULSPID { get; set; } 

        public void Validate()
        {
            new EditGnrUserLogCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
