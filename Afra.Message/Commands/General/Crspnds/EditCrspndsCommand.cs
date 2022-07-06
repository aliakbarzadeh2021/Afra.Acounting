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
    public class EditCrspndsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CrspndId { get; set; }  
 
		public String CrspndName { get; set; }  
 
		public String CrsDLRef { get; set; }  
 
		public Int32 CrsType { get; set; }  
 
		public String ECode { get; set; }  
 
		public Nullable<Int32> AcCtgry { get; set; }  
 
		public String RegNo { get; set; }  
 
		public String NatCode { get; set; }  
 
		public String CrsTitle { get; set; } 

        public void Validate()
        {
            new EditCrspndsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
