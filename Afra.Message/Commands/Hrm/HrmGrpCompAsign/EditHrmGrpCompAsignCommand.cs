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
    public class EditHrmGrpCompAsignCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 HrmGrpCompAsgnId { get; set; }  
 
		public Nullable<Int32> HGCAStatRef { get; set; }  
 
		public Nullable<Int32> HGCACompRef { get; set; }  
 
		public Nullable<Int32> HGCACompBrnRef { get; set; }  
 
		public Nullable<Int32> HGCAIsRel { get; set; } 

        public void Validate()
        {
            new EditHrmGrpCompAsignCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
