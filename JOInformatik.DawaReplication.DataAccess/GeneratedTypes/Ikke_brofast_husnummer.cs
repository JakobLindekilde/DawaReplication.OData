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
    [Table("ikke_brofast_husnummer")]
    public partial class Ikke_brofast_husnummer : ReplicationBase
    {
        /// <summary>This constructor calls OnCreated().</summary>
        public Ikke_brofast_husnummer()
        {
            EntityUpdated = DateTime.Now;
            OnCreated();
        }

        /// <summary>
        /// DETTE ER PKEY. Det ikke brofaste husnummers UUID
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.None), Column("husnummerid")]
        [Required()]
        public virtual Guid Husnummerid { get; set; }

        /// <summary>Overwrite this method to do your own initialization of the entity.</summary>
        partial void OnCreated();

        /// Returns the primary key as a string (includes all columns).</summary>
        public override string DawaPkey
        {
            get
            {
                if (_dawaPkey == null)
                {
                    _dawaPkey = Husnummerid.ToString();
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