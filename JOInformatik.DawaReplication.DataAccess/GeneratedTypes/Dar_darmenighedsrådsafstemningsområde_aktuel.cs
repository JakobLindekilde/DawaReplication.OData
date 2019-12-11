//-----------------------------------------------------------------------------------------------
// This is auto-generated code.
//-----------------------------------------------------------------------------------------------
// This code was generated by JO Informatik DAWA Replication tool version 1.0.2.0
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
//-----------------------------------------------------------------------------------------------
using Microsoft.SqlServer.Types;
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JOInformatik.DawaReplication.DataAccess
{
    /// <summary>TODO.</summary>
    [GeneratedCode("JO Informatik DAWA Replication tool", "version 1.0.2.0")]
    [Table("dar_darmenighedsrådsafstemningsområde_aktuel")]
    public partial class Dar_darmenighedsrådsafstemningsområde_aktuel : ReplicationBase
    {
        /// <summary>This constructor calls OnCreated().</summary>
        public Dar_darmenighedsrådsafstemningsområde_aktuel()
        {
            EntityUpdated = DateTime.Now;
            OnCreated();
        }

        /// <summary>
        /// DETTE ER PKEY. Ikke tilgængelig
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.None), Column("id")]
        [Required()]
        public virtual Guid Id { get; set; }

        /// <summary>
        /// Ikke tilgængelig
        /// </summary>
        
        [Column("status")]
        [Required()]
        public virtual int Status { get; set; }

        /// <summary>
        /// Ikke tilgængelig
        /// </summary>
        
        [Column("mrafstemningsområde", TypeName = "varchar(200)")]
        public virtual string Mrafstemningsområde { get; set; }

        /// <summary>
        /// Ikke tilgængelig
        /// </summary>
        
        [Column("mrafstemningsområdenummer")]
        public virtual int? Mrafstemningsområdenummer { get; set; }

        /// <summary>
        /// Ikke tilgængelig
        /// </summary>
        
        [Column("navn", TypeName = "varchar(200)")]
        public virtual string Navn { get; set; }

        /// <summary>Overwrite this method to do your own initialization of the entity.</summary>
        partial void OnCreated();

        /// Returns the primary key as a string (includes all columns).</summary>
        public override string DawaPkey
        {
            get
            {
                if (_dawaPkey == null)
                {
                    _dawaPkey = Id.ToString();
                }
                return _dawaPkey;
            }
        }

        [Column("entity_updated")]
        [Required()]
        /// <summary>Tidspunktet da rækken blev oprettet eller ændret i databasen hos JOI.</summary>
        public DateTime EntityUpdated { get; set; }

    }
}
