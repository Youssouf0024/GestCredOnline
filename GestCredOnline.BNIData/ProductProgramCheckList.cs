//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GestCredOnline.BNIData
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductProgramCheckList
    {
        public long CheckListID { get; set; }
        public Nullable<long> ProductProgramID { get; set; }
        public string Createur { get; set; }
        public Nullable<System.DateTime> DateCreation { get; set; }
        public string Modificateur { get; set; }
        public Nullable<System.DateTime> DateModification { get; set; }
        public string Libelle { get; set; }
    
        public virtual ProductProgram ProductProgram { get; set; }
    }
}
