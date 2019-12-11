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
    [Table("bbr_ejendomsrelation")]
    public partial class Bbr_ejendomsrelation : ReplicationBase
    {
        /// <summary>This constructor calls OnCreated().</summary>
        public Bbr_ejendomsrelation()
        {
            EntityUpdated = DateTime.Now;
            OnCreated();
        }

        /// <summary>
        /// DETTE ER PKEY. Unik ID for den angivne række. 
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.None), Column("rowkey")]
        [Required()]
        public virtual int Rowkey { get; set; }

        /// <summary>
        /// Startidspunktet for rækkens virkningstid.
        /// </summary>
        
        [Column("virkningstart")]
        [Required()]
        public virtual DateTime Virkningstart { get; set; }

        /// <summary>
        /// Sluttidspunktet for rækkens virkningstid. 
        /// </summary>
        
        [Column("virkningslut")]
        public virtual DateTime? Virkningslut
        {
            get { return _Virkningslut.GetValueOrDefault(Defaults.Virkningslut); }
            set { _Virkningslut = value; }
        }
        private DateTime? _Virkningslut;

        /// <summary>
        /// Startidspunktet for rækkens registreringstid.
        /// </summary>
        
        [Column("registreringstart")]
        [Required()]
        public virtual DateTime Registreringstart { get; set; }

        /// <summary>
        /// Sluttidspunktet for rækkens registreringstid. 
        /// </summary>
        
        [Column("registreringslut")]
        public virtual DateTime? Registreringslut
        {
            get { return _Registreringslut.GetValueOrDefault(Defaults.Registreringslut); }
            set { _Registreringslut = value; }
        }
        private DateTime? _Registreringslut;

        /// <summary>
        /// Kode for den forretningshændelse, som afstedkom opdateringen af bygværkselementet til den pågældende version For mulige værdier, se <a href="https://ki.bbr.dk/kodelister-bbr/0/1/0/Forretningshaendelse">kodelisten.</a>
        /// </summary>
        
        [Column("forretningshændelse", TypeName = "varchar(50)")]
        public virtual string Forretningshændelse { get; set; }

        /// <summary>
        /// FORM-kode for det offentlige forretningsområde som har opdateret bygværkselementet til den pågældende version For mulige værdier, se <a href="https://ki.bbr.dk/kodelister-bbr/0/1/0/ForretningsOmraade">kodelisten.</a>
        /// </summary>
        
        [Column("forretningsområde", TypeName = "varchar(15)")]
        public virtual string Forretningsområde { get; set; }

        /// <summary>
        /// Kode for den forretningshændelse, som afstedkom opdateringen af bygværkselementet til den pågældende version For mulige værdier, se <a href="https://ki.bbr.dk/kodelister-bbr/0/1/0/ForretningsProcess">kodelisten.</a>
        /// </summary>
        
        [Column("forretningsproces", TypeName = "varchar(2)")]
        public virtual string Forretningsproces { get; set; }

        /// <summary>
        /// Unik og uforanderlig identifikation af ejendomsrelationen igennem hele dens livscyklus
        /// </summary>
        
        [Column("id")]
        public virtual Guid? Id { get; set; }

        /// <summary>
        /// Kode der identificerer den kommune som bygværkselementet hidhører For mulige værdier, se <a href="https://ki.bbr.dk/kodelister-bbr/0/1/0/Kommunekode">kodelisten.</a>
        /// </summary>
        
        [Column("kommunekode", TypeName = "varchar(4)")]
        public virtual string Kommunekode { get; set; }

        /// <summary>
        /// Kode som angiver hvilken aktør der har foretaget registreringen af den pågældende version af bygværkselementet
        /// </summary>
        
        [Column("registreringsaktør", TypeName = "varchar(90)")]
        public virtual string Registreringsaktør { get; set; }

        /// <summary>
        /// Kode for bygværkselementets status i den pågældende version, dvs. elementets tilstand i den samlede livscyklus For mulige værdier, se <a href="https://ki.bbr.dk/kodelister-bbr/0/1/0/Livscyklus">kodelisten.</a>
        /// </summary>
        
        [Column("status", TypeName = "varchar(2)")]
        public virtual string Status { get; set; }

        /// <summary>
        /// Kode for den aktør der har afstedkommet virkningsegenskaberne for den pågældende version af bygværkselementet For mulige værdier, se <a href="https://ki.bbr.dk/kodelister-bbr/0/1/0/Virkningsakt%C3%B8r">kodelisten.</a>
        /// </summary>
        
        [Column("virkningsaktør", TypeName = "varchar(90)")]
        public virtual string Virkningsaktør { get; set; }

        /// <summary>
        /// Angiver den fælles ejendomsidentifikation for den bestemte faste ejendom som den tilhørende BBR-entitet udgør eller indgår i
        /// </summary>
        
        [Column("bfeNummer")]
        public virtual int? BfeNummer { get; set; }

        /// <summary>
        /// Ejerforholdskode for hovedejeren for den ejendom som denne ejendomsrelation refrerer til, baseret på Ejerfortegnelsens oplysninger om ejerskaber ejendommen For mulige værdier, se <a href="https://ki.bbr.dk/kodelister-bbr/0/1/0/Ejerforholdskode">kodelisten.</a>
        /// </summary>
        
        [Column("ejendommensEjerforholdskode", TypeName = "varchar(2)")]
        public virtual string EjendommensEjerforholdskode { get; set; }

        /// <summary>
        /// Ejendomsnummer for den ESR-ejendom som denne ejendomsrelation indgår i
        /// </summary>
        
        [Column("ejendomsnummer")]
        public virtual int? Ejendomsnummer { get; set; }

        /// <summary>
        /// Liste med koder vedrørende ejendomstype For mulige værdier, se <a href="https://ki.bbr.dk/kodelister-bbr/0/1/0/Ejendomstype">kodelisten.</a>
        /// </summary>
        
        [Column("ejendomstype", TypeName = "varchar(40)")]
        public virtual string Ejendomstype { get; set; }

        /// <summary>
        /// 
        /// </summary>
        
        [Column("ejerlejlighedsnummer")]
        public virtual int? Ejerlejlighedsnummer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        
        [Column("tinglystAreal")]
        public virtual int? TinglystAreal { get; set; }

        /// <summary>
        /// Angiver SKAT's vurderingsejendomsnummer som denne Ejendomsrelation indgår i
        /// </summary>
        
        [Column("vurderingsejendomsnummer")]
        public virtual int? Vurderingsejendomsnummer { get; set; }

        /// <summary>Overwrite this method to do your own initialization of the entity.</summary>
        partial void OnCreated();

        /// Returns the primary key as a string (includes all columns).</summary>
        public override string DawaPkey
        {
            get
            {
                if (_dawaPkey == null)
                {
                    _dawaPkey = Rowkey.ToString();
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
