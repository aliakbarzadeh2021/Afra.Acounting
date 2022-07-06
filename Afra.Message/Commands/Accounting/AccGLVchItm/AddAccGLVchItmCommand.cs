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
    public class AddAccGLVchItmCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 AccGLVchItmId { get; set; }  
 
		public Nullable<Int32> AccGLVchHdrRef { get; set; }  
 
		public String AGVIGLRef { get; set; }  
 
		public Nullable<Double> AGVIDebit { get; set; }  
 
		public Nullable<Double> AGVICredit { get; set; } 

        public void Validate()
        {
            new AddAccGLVchItmCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
