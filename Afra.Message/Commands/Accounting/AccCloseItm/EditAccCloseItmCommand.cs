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
    public class EditAccCloseItmCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 AccCloseItmId { get; set; }  
 
		public Nullable<Int32> AccCloseHdrRef { get; set; }  
 
		public String ACIGLRef { get; set; }  
 
		public String ACISLRef { get; set; }  
 
		public String ACIDLRef { get; set; }  
 
		public String ACIDLFive { get; set; }  
 
		public String ACIDLSix { get; set; } 

        public void Validate()
        {
            new EditAccCloseItmCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
