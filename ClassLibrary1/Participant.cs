//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Participant
    {
        public System.Guid TournamentID { get; set; }
        public System.Guid TeamID { get; set; }
        public Nullable<int> Place { get; set; }
        public Nullable<int> Money { get; set; }
    
        public virtual Team Team { get; set; }
        public virtual Tournament Tournament { get; set; }
    }
}
