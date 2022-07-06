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
    public class EditPrdOrdHdrCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PrdOrdHdrId { get; set; }  
 
		public Int32 POHNum { get; set; }  
 
		public Nullable<Int32> POHLocalNum { get; set; }  
 
		public Int32 POHType { get; set; }  
 
		public DateTime POHDate { get; set; }  
 
		public String POHDLRef { get; set; }  
 
		public String POHDescr { get; set; }  
 
		public Nullable<Int32> Creator { get; set; }  
 
		public Nullable<Int32> Confimer { get; set; }  
 
		public Nullable<Int32> POHState { get; set; }  
 
		public Nullable<Int32> POHYear { get; set; }  
 
		public Nullable<Int32> POHRefID { get; set; }  
 
		public Nullable<Int32> POHRefType { get; set; } 

        public void Validate()
        {
            new EditPrdOrdHdrCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
