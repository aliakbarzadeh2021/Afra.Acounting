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
    public class AddHrmPersRltdCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PersRltdId { get; set; }  
 
		public Nullable<Int32> PersRltdPersRef { get; set; }  
 
		public DateTime PersRltdBDate { get; set; }  
 
		public String PersRltdFullName { get; set; }  
 
		public String PersRltdType { get; set; }  
 
		public Nullable<Int32> PersRltdHaveInsu { get; set; } 

        public void Validate()
        {
            new AddHrmPersRltdCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
