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
    public class EditUsrMissionDetCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Nullable<Int32> ParentId { get; set; }  
 
		public Nullable<Int32> Creator { get; set; }  
 
		public Nullable<Int32> Confimer { get; set; }  
 
		public Nullable<Int32> State { get; set; }  
 
		public String Mahal { get; set; }  
 
		public Nullable<Int32> Sobhane { get; set; }  
 
		public Nullable<Int32> Nahar { get; set; }  
 
		public Nullable<Int32> Sham { get; set; }  
 
		public Nullable<Int32> Ruz { get; set; }  
 
		public Nullable<Int32> Mehmansara { get; set; }  
 
		public Nullable<Int32> Karvan { get; set; }  
 
		public Nullable<Int32> Khab { get; set; }  
 
		public Nullable<Int32> FoghShabane { get; set; }  
 
		public Nullable<Int32> Saku { get; set; }  
 
		public Nullable<Int32> Aghmar { get; set; }  
 
		public Nullable<Int32> AyabZahab { get; set; }  
 
		public Nullable<Int32> Khoshk { get; set; }  
 
		public Nullable<Int32> Elima { get; set; } 

        public void Validate()
        {
            new EditUsrMissionDetCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
