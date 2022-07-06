using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class HrmPersLang : BaseEntity
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


