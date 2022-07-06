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
    public class EditBdgContsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 BdgContsId { get; set; }  
 
		public Int32 BCNum { get; set; }  
 
		public DateTime BCDate { get; set; }  
 
		public String BCDescr { get; set; }  
 
		public Double BCAmount { get; set; }  
 
		public Int32 BCPeriodRef { get; set; }  
 
		public Nullable<Int32> BCCurRef { get; set; }  
 
		public String BCMainSLRef { get; set; } 

        public void Validate()
        {
            new EditBdgContsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
