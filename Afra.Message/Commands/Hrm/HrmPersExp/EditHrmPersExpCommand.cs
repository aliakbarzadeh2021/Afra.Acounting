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
    public class EditHrmPersExpCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PersExpId { get; set; }  
 
		public Nullable<Int32> PersExpPersRef { get; set; }  
 
		public DateTime PersExpFDate { get; set; }  
 
		public DateTime PersExpTDate { get; set; }  
 
		public String PersExpExType { get; set; }  
 
		public String PersExpCompName { get; set; }  
 
		public Nullable<Int32> PersExpInsuDays { get; set; } 

        public void Validate()
        {
            new EditHrmPersExpCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
