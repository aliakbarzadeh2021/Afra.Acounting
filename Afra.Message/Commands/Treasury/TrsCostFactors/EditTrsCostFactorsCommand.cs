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
    public class EditTrsCostFactorsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 TrsCostFactorId { get; set; }  
 
		public Int32 TCFCode { get; set; }  
 
		public Nullable<Int32> TCFParent { get; set; }  
 
		public String TCFTitle { get; set; }  
 
		public String TCFSLRef { get; set; }  
 
		public String TCFDLRef { get; set; }  
 
		public String TCFDLFive { get; set; }  
 
		public String TCFDLSix { get; set; } 

        public void Validate()
        {
            new EditTrsCostFactorsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
