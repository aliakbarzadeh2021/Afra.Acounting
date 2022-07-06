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
    public class AddGnrLimitGroupCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 GnrLimitGroupId { get; set; }  
 
		public String GLGTitle { get; set; }  
 
		public String GLGName { get; set; }  
 
		public Int32 GLGSit { get; set; }  
 
		public String GLGObjView { get; set; }  
 
		public String GLGObjIdCol { get; set; }  
 
		public String GLGObjTitleCol { get; set; }  
 
		public String GLGObjTitle { get; set; } 

        public void Validate()
        {
            new AddGnrLimitGroupCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
