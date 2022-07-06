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
    public class AddAccCloseHdrCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 AccCloseHdrId { get; set; }  
 
		public String ACHDescr { get; set; }  
 
		public String ACHType { get; set; }  
 
		public String ACHSLRef { get; set; }  
 
		public String ACHDLRef { get; set; }  
 
		public String ACHDLFive { get; set; }  
 
		public String ACHDLSix { get; set; }  
 
		public Int32 ACHAccPrdRef { get; set; }  
 
		public Nullable<Int32> AccVchHdrRef { get; set; } 

        public void Validate()
        {
            new AddAccCloseHdrCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
