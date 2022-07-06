using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class GnrUserRefList : BaseEntity
    {
          
 
		public Int32 GnrUserRefListId { get; set; }  
 
		public String GURLTitle { get; set; }  
 
		public String GURLViewName { get; set; }  
 
		public String GURLIdFieldName { get; set; }  
 
		public String GURLDesFieldName { get; set; } 
    }
}


