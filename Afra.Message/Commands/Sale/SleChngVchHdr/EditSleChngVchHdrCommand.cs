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
    public class EditSleChngVchHdrCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 SleChngVchHdrID { get; set; }  
 
		public Int32 SCVHNum { get; set; }  
 
		public Nullable<Int32> SCVHLocalNum { get; set; }  
 
		public DateTime SCVHDate { get; set; }  
 
		public String SCVHDescr { get; set; }  
 
		public Int32 SCVHVchType { get; set; }  
 
		public Nullable<Int32> Creator { get; set; }  
 
		public Nullable<Int32> Confimer { get; set; }  
 
		public Nullable<Int32> SCVHState { get; set; }  
 
		public Nullable<Int32> SCVAccPrdRef { get; set; } 

        public void Validate()
        {
            new EditSleChngVchHdrCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
