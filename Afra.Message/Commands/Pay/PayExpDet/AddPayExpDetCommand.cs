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
    public class AddPayExpDetCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PayExpDetId { get; set; }  
 
		public Nullable<Int32> PayExpFileRef { get; set; }  
 
		public Nullable<Int32> PEDSeq { get; set; }  
 
		public Nullable<Int32> PEDLoc { get; set; }  
 
		public String PEDFieldRef { get; set; }  
 
		public String PEDName { get; set; }  
 
		public String PEDTitle { get; set; }  
 
		public Nullable<Int32> PEDFldType { get; set; }  
 
		public Nullable<Int32> PEDSize { get; set; }  
 
		public String PEDDefVal { get; set; }  
 
		public String PEDFill { get; set; } 

        public void Validate()
        {
            new AddPayExpDetCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
