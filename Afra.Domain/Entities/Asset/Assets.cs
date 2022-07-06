using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class Assets : BaseEntity
    {
          
 
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
    }
}


