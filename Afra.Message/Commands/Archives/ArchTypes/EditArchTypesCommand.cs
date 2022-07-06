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
    public class EditArchTypesCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 ArchTypeId { get; set; }  
 
		public Int32 AcTTableRef { get; set; }  
 
		public String AcTTitle { get; set; }  
 
		public Nullable<Int32> AcTIsDef { get; set; }  
 
		public Nullable<Int32> AcGrpRef { get; set; } 

        public void Validate()
        {
            new EditArchTypesCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
