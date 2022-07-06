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
    public class EditHrmPersSldrCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PersSoldrId { get; set; }  
 
		public Int32 PersSoldrPersRef { get; set; }  
 
		public DateTime PersSoldrDate { get; set; }  
 
		public String PersSoldrSit { get; set; }  
 
		public String PersSoldrDescr { get; set; } 

        public void Validate()
        {
            new EditHrmPersSldrCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
