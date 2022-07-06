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
    public class AddPrdConsumHdrCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PrdConsumHdrId { get; set; }  
 
		public Int32 PCHNum { get; set; }  
 
		public Nullable<Int32> PCHLocalNum { get; set; }  
 
		public DateTime PCHDate { get; set; }  
 
		public String PCHDescr { get; set; }  
 
		public Int32 PCHProgRef { get; set; }  
 
		public String PCHDLRef { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public Nullable<Int32> Confimer { get; set; }  
 
		public Nullable<Int32> PCHState { get; set; }  
 
		public Nullable<Int32> PCHYear { get; set; } 

        public void Validate()
        {
            new AddPrdConsumHdrCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
