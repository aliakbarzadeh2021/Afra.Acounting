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
    public class AddTrsAccOprCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 TrsOprId { get; set; }  
 
		public Int32 TrsOprCode { get; set; }  
 
		public String TrsOprDescr { get; set; }  
 
		public String TrsOprType { get; set; }  
 
		public String TrsOprRole { get; set; }  
 
		public Nullable<Int32> TrsOprVtType { get; set; }  
 
		public String TrsOprSLRef { get; set; }  
 
		public Nullable<Int32> TrsOprDL4Type { get; set; }  
 
		public String TrsOprDL4Code { get; set; }  
 
		public Nullable<Int32> TrsOprDL5Type { get; set; }  
 
		public String TrsOprDL5Code { get; set; }  
 
		public Nullable<Int32> TrsOprDL6Type { get; set; }  
 
		public Nullable<Int32> TrsOprDL6Code { get; set; }  
 
		public Nullable<Int32> TrsOprItmType { get; set; }  
 
		public Nullable<Int32> TrsOprVtItmType { get; set; }  
 
		public Nullable<Int32> TrsOprHaveAcc { get; set; }  
 
		public Nullable<Int32> TrsOprPayItmType { get; set; }  
 
		public Nullable<Int32> TrsOprOpositType { get; set; }  
 
		public Nullable<Int32> TrsOprItmNorm { get; set; }  
 
		public Nullable<Int32> TrsOprCur { get; set; } 

        public void Validate()
        {
            new AddTrsAccOprCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
