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
    public class EditTrsPayBoredOprCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PBOHdrId { get; set; }  
 
		public Int32 PBONum { get; set; }  
 
		public Nullable<Int32> PBOLocalNum { get; set; }  
 
		public DateTime PBODate { get; set; }  
 
		public String PBODescr { get; set; }  
 
		public Nullable<Int32> Creator { get; set; }  
 
		public Nullable<Int32> Confimer { get; set; }  
 
		public Nullable<Int32> PBOState { get; set; }  
 
		public Nullable<Int32> TPAccPrdRef { get; set; }  
 
		public Nullable<Int32> PBOCreator { get; set; }  
 
		public Nullable<Int32> PBOSit { get; set; } 

        public void Validate()
        {
            new EditTrsPayBoredOprCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
