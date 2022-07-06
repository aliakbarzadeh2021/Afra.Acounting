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
    public class AddShopsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 ShopsId { get; set; }  
 
		public String ShopName { get; set; }  
 
		public String ShopDb { get; set; }  
 
		public Nullable<Int32> ShopSaleBranch { get; set; }  
 
		public Nullable<Int32> ShopStock { get; set; } 

        public void Validate()
        {
            new AddShopsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
