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
    public class AddAssetsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 AstId { get; set; }  
 
		public String AstPlatNo { get; set; }  
 
		public String AstTitle { get; set; }  
 
		public DateTime AstCreateDate { get; set; }  
 
		public DateTime AstUseDate { get; set; }  
 
		public Nullable<Int32> AstDocRef { get; set; }  
 
		public String AstSLRef { get; set; }  
 
		public String AstDLRef { get; set; }  
 
		public String AstDLFive { get; set; }  
 
		public String AstDLSix { get; set; } 

        public void Validate()
        {
            new AddAssetsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
