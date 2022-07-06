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
    public class AddPayFixElmntValCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PayFixElmntValId { get; set; }  
 
		public Int32 PFEVElmntRef { get; set; }  
 
		public Int32 PFEVYear { get; set; }  
 
		public Int32 PFEVMonth { get; set; }  
 
		public Double PFEVAmount { get; set; }  
 
		public Nullable<Int32> PFEVYearMonth { get; set; } 

        public void Validate()
        {
            new AddPayFixElmntValCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
