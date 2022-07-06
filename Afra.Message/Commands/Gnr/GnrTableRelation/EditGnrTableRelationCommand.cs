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
    public class EditGnrTableRelationCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 GnrTableRelationId { get; set; }  
 
		public String RelationName { get; set; }  
 
		public String RelationTitle { get; set; } 

        public void Validate()
        {
            new EditGnrTableRelationCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
