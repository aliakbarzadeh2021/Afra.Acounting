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
    public class EditElmntMethodCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 EmthdId { get; set; }  
 
		public Int32 EmthdElmntRef { get; set; }  
 
		public Int32 EmthdEmpRef { get; set; }  
 
		public Int32 EmthdIYear { get; set; }  
 
		public Int32 EmthdIMonth { get; set; }  
 
		public Int32 EmthdEYear { get; set; }  
 
		public Int32 EmthdEMonth { get; set; }  
 
		public Nullable<Int32> EmthdIYearMonth { get; set; }  
 
		public Nullable<Int32> EmthdEYearMonth { get; set; }  
 
		public Nullable<Int32> EmthdAct { get; set; }  
 
		public String EmthdFormula { get; set; }  
 
		public Nullable<Int32> EmthdRoles { get; set; }  
 
		public Nullable<DateTime> EmthdLastChange { get; set; } 

        public void Validate()
        {
            new EditElmntMethodCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
