//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PPE3_Github_Tajek
{
    using System;
    using System.Collections.Generic;
    
    public partial class MEDICAMENT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MEDICAMENT()
        {
            this.OFFRIR = new HashSet<OFFRIR>();
        }
    
        public string idMedicament { get; set; }
        public string nomCommercial { get; set; }
        public string idFamille { get; set; }
        public string composition { get; set; }
        public string effets { get; set; }
        public string contreIndications { get; set; }
    
        public virtual FAMILLE FAMILLE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OFFRIR> OFFRIR { get; set; }
    }
}
