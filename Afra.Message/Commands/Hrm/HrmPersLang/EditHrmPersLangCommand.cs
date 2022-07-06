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
    public class EditHrmPersLangCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PersLangId { get; set; }  
 
		public Nullable<Int32> PersLangPersRef { get; set; }  
 
		public DateTime PersLangDate { get; set; }  
 
		public String PersLangRef { get; set; }  
 
		public String PersLangDegName { get; set; }  
 
		public Nullable<Int32> PersLangRead { get; set; }  
 
		public Nullable<Int32> PersLangWrite { get; set; }  
 
		public Nullable<Int32> PersLangTalk { get; set; } 

        public void Validate()
        {
            new EditHrmPersLangCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
