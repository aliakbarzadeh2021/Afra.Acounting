using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class HrmPersLangDto
    {
          
 
		public Int32 PersLangId { get; set; }  
 
		public Nullable<Int32> PersLangPersRef { get; set; }  
 
		public DateTime PersLangDate { get; set; }  
 
		public String PersLangRef { get; set; }  
 
		public String PersLangDegName { get; set; }  
 
		public Nullable<Int32> PersLangRead { get; set; }  
 
		public Nullable<Int32> PersLangWrite { get; set; }  
 
		public Nullable<Int32> PersLangTalk { get; set; } 
    }
}


