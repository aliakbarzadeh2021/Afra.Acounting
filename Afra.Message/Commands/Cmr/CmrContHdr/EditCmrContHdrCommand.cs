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
    public class EditCmrContHdrCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CmrContHdrId { get; set; }  
 
		public Int32 CCHNum { get; set; }  
 
		public DateTime CCHDate { get; set; }  
 
		public Int32 CCHSellerRef { get; set; }  
 
		public String CCHDescr { get; set; }  
 
		public Nullable<Int32> Creator { get; set; }  
 
		public Nullable<Int32> Confimer { get; set; }  
 
		public Nullable<Int32> CCHState { get; set; }  
 
		public Nullable<Int32> CAccPrdRef { get; set; }  
 
		public Nullable<Int32> CCHRefID { get; set; }  
 
		public Nullable<Int32> CCHRefType { get; set; } 

        public void Validate()
        {
            new EditCmrContHdrCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
