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
    public class AddInvStockCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 StockId { get; set; }  
 
		public String StockCode { get; set; }  
 
		public String StockName { get; set; }  
 
		public String StckType { get; set; }  
 
		public String StckSLRef { get; set; }  
 
		public Nullable<Int32> StckDL4Type { get; set; }  
 
		public String StckDL4Code { get; set; }  
 
		public Nullable<Int32> StckDL5Type { get; set; }  
 
		public String StckDL5Code { get; set; }  
 
		public Nullable<Int32> StckDL6Type { get; set; }  
 
		public String StckDL6Code { get; set; } 

        public void Validate()
        {
            new AddInvStockCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
