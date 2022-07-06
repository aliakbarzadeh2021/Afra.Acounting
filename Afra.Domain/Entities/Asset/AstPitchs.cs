using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class AstPitchs : BaseEntity
    {
          
 
		public Int32 AstPitchId { get; set; }  
 
		public Nullable<Int32> AstPitchParent { get; set; }  
 
		public String AstPitchCode { get; set; }  
 
		public String AstPitchTitle { get; set; }  
 
		public Nullable<Int32> APMainRoot { get; set; } 
    }
}


