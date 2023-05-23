//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GestCredOnline.WebAPI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Request
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Request()
        {
            this.Fichier = new HashSet<Fichier>();
        }
    
        public long RequestID { get; set; }
        public string Ref_req { get; set; }
        public string CreditObjet { get; set; }
        public Nullable<int> CreditMontant { get; set; }
        public Nullable<double> CreditTaux { get; set; }
        public Nullable<long> CreditProgramID { get; set; }
        public string CreditProgram { get; set; }
        public Nullable<byte> DemandeEtat { get; set; }
        public Nullable<System.DateTime> DemandeDate { get; set; }
        public string AccountRacine { get; set; }
        public Nullable<int> CreditDuree { get; set; }
        public Nullable<long> PersonID { get; set; }
        public Nullable<byte> SyncStatut { get; set; }
        public Nullable<byte> CreditPeriodicite { get; set; }
        public string Reference { get; set; }
        public string SPItemID { get; set; }
        public string DemandeDossier { get; set; }
        public string AccountNumber { get; set; }
        public Nullable<int> CreditMontantAvance { get; set; }
        public Nullable<int> CreditMontantEcheance { get; set; }
        public string CreditMontantLettre { get; set; }
        public Nullable<double> CreditQuotite { get; set; }
        public Nullable<int> Score { get; set; }
        public Nullable<int> Note { get; set; }
        public string Risque { get; set; }
        public Nullable<double> CreditTauxEndettement { get; set; }
        public Nullable<bool> AcompteEpargne { get; set; }
        public Nullable<System.DateTime> CreditDatePremVersement { get; set; }
        public Nullable<int> AncienneteClient { get; set; }
    
        public virtual Client Client { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Fichier> Fichier { get; set; }
        public virtual ProductProgram ProductProgram { get; set; }
        public virtual Request Request1 { get; set; }
        public virtual Request Request2 { get; set; }
    }
}