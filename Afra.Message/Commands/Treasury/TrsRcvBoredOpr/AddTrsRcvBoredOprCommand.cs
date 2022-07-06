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
    public class AddTrsRcvBoredOprCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 RBOHdrId { get; set; }  
 
		public Int32 RBONum { get; set; }  
 
		public Nullable<Int32> RBOLocalNum { get; set; }  
 
		public DateTime RBODate { get; set; }  
 
		public String RBODescr { get; set; }  
 
		public Nullable<Int32> Creator { get; set; }  
 
		public Nullable<Int32> Confimer { get; set; }  
 
		public Nullable<Int32> RBOState { get; set; }  
 
		public Nullable<Int32> TRAccPrdRef { get; set; }  
 
		public Nullable<Int32> RBOCreator { get; set; }  
 
		public Nullable<Int32> RBOSit { get; set; } 

        public void Validate()
        {
            new AddTrsRcvBoredOprCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
