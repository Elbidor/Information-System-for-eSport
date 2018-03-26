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
    
    public partial class Team
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Team()
        {
            this.MatchesInTournaments = new HashSet<MatchesInTournament>();
            this.MatchesInTournaments1 = new HashSet<MatchesInTournament>();
            this.Participants = new HashSet<Participant>();
            this.PlayersInTeams = new HashSet<PlayersInTeam>();
        }
    
        public System.Guid TeamID { get; set; }
        public string Name { get; set; }
        public System.Guid RegionID { get; set; }
        public int Wins { get; set; }
        public int Draws { get; set; }
        public int Defeats { get; set; }
        public int Money { get; set; }
        public int Rating { get; set; }
        public System.Guid ManagerID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MatchesInTournament> MatchesInTournaments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MatchesInTournament> MatchesInTournaments1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Participant> Participants { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlayersInTeam> PlayersInTeams { get; set; }
        public virtual Region Region { get; set; }
    }
}
