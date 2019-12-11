using JOInformatik.DawaReplication.DataAccess;
using Microsoft.AspNet.OData.Builder;

namespace DawaReplication.OData
{
    public static class ODataHelper
    {
        public static Microsoft.OData.Edm.IEdmModel BuildEdmModel()
        {
            ODataConventionModelBuilder modelBuilder = new ODataConventionModelBuilder();

            modelBuilder.EntitySet<Entitystate>("Entitystate").EntityType
                .HasKey(c => new { c.Entity });
            modelBuilder.EntitySet<EntitystateHistory>("EntitystateHistory").EntityType
                .HasKey(c => new { c.Entity, c.Starttime });

            modelBuilder.EntitySet<Adgangsadresse>("Adgangsadresse").EntityType
                .HasKey(c => new { c.Id });
            modelBuilder.EntitySet<Adresse>("Adresse").EntityType
                .HasKey(c => new { c.Id });
            modelBuilder.EntitySet<Afstemningsområde>("Afstemningsområde").EntityType
                .HasKey(c => new { c.Kommunekode, c.Nummer });
            modelBuilder.EntitySet<Afstemningsområdetilknytning>("Afstemningsområdetilknytning").EntityType
                .HasKey(c => new { c.Adgangsadresseid, c.Kommunekode, c.Afstemningsområdenummer });
            modelBuilder.EntitySet<Brofasthed>("Brofasthed").EntityType
                .HasKey(c => new { c.Stedid });
            modelBuilder.EntitySet<Bygning>("Bygning").EntityType
                .HasKey(c => new { c.Id });
            modelBuilder.EntitySet<Bygningtilknytning>("Bygningtilknytning").EntityType
                .HasKey(c => new { c.Bygningid, c.Adgangsadresseid });
            modelBuilder.EntitySet<Dagi_postnummer>("Dagi_postnummer").EntityType
                .HasKey(c => new { c.Nr });
            modelBuilder.EntitySet<Ejerlav>("Ejerlav").EntityType
                .HasKey(c => new { c.Kode });
            modelBuilder.EntitySet<Højde>("Højde").EntityType
                .HasKey(c => new { c.Husnummerid });
            modelBuilder.EntitySet<Ikke_brofast_husnummer>("Ikke_brofast_husnummer").EntityType
                .HasKey(c => new { c.Husnummerid });
            modelBuilder.EntitySet<Jordstykke>("Jordstykke").EntityType
                .HasKey(c => new { c.Ejerlavkode, c.Matrikelnr });
            modelBuilder.EntitySet<Jordstykketilknytning>("Jordstykketilknytning").EntityType
                .HasKey(c => new { c.Ejerlavkode, c.Matrikelnr, c.Adgangsadresseid });
            modelBuilder.EntitySet<Kommune>("Kommune").EntityType
                .HasKey(c => new { c.Kode });
            modelBuilder.EntitySet<Kommunetilknytning>("Kommunetilknytning").EntityType
                .HasKey(c => new { c.Adgangsadresseid, c.Kommunekode });
            modelBuilder.EntitySet<Landpostnummer>("Landpostnummer").EntityType
                .HasKey(c => new { c.Nr });
            modelBuilder.EntitySet<Menighedsrådsafstemningsområde>("Menighedsrådsafstemningsområde").EntityType
                .HasKey(c => new { c.Kommunekode, c.Nummer });
            modelBuilder.EntitySet<Menighedsrådsafstemningsområdetilknytning>("Menighedsrådsafstemningsområdetilknytning").EntityType
                .HasKey(c => new { c.Adgangsadresseid, c.Kommunekode, c.Menighedsrådsafstemningsområdenummer });
            modelBuilder.EntitySet<Navngivenvej>("Navngivenvej").EntityType
                .HasKey(c => new { c.Id });
            modelBuilder.EntitySet<Opstillingskreds>("Opstillingskreds").EntityType
                .HasKey(c => new { c.Kode });
            modelBuilder.EntitySet<Opstillingskredstilknytning>("Opstillingskredstilknytning").EntityType
                .HasKey(c => new { c.Adgangsadresseid, c.Opstillingskredskode });
            modelBuilder.EntitySet<Politikreds>("Politikreds").EntityType
                .HasKey(c => new { c.Kode });
            modelBuilder.EntitySet<Politikredstilknytning>("Politikredstilknytning").EntityType
                .HasKey(c => new { c.Adgangsadresseid, c.Politikredskode });
            modelBuilder.EntitySet<Postnummer>("Postnummer").EntityType
                .HasKey(c => new { c.Nr });
            modelBuilder.EntitySet<Postnummertilknytning>("Postnummertilknytning").EntityType
                .HasKey(c => new { c.Adgangsadresseid, c.Postnummer });
            modelBuilder.EntitySet<Region>("Region").EntityType
                .HasKey(c => new { c.Kode });
            modelBuilder.EntitySet<Regionstilknytning>("Regionstilknytning").EntityType
                .HasKey(c => new { c.Adgangsadresseid, c.Regionskode });
            modelBuilder.EntitySet<Retskreds>("Retskreds").EntityType
                .HasKey(c => new { c.Kode });
            modelBuilder.EntitySet<Retskredstilknytning>("Retskredstilknytning").EntityType
                .HasKey(c => new { c.Adgangsadresseid, c.Retskredskode });
            modelBuilder.EntitySet<Sogn>("Sogn").EntityType
                .HasKey(c => new { c.Kode });
            modelBuilder.EntitySet<Sognetilknytning>("Sognetilknytning").EntityType
                .HasKey(c => new { c.Adgangsadresseid, c.Sognekode });
            modelBuilder.EntitySet<Sted>("Sted").EntityType
                .HasKey(c => new { c.Id });
            modelBuilder.EntitySet<Stednavn>("Stednavn").EntityType
                .HasKey(c => new { c.Stedid, c.Navn });
            modelBuilder.EntitySet<Stednavntilknytning>("Stednavntilknytning").EntityType
                .HasKey(c => new { c.Stednavn_id, c.Adgangsadresse_id });
            modelBuilder.EntitySet<Stedtilknytning>("Stedtilknytning").EntityType
                .HasKey(c => new { c.Stedid, c.Adgangsadresseid });
            modelBuilder.EntitySet<Storkreds>("Storkreds").EntityType
                .HasKey(c => new { c.Nummer });
            modelBuilder.EntitySet<Storkredstilknytning>("Storkredstilknytning").EntityType
                .HasKey(c => new { c.Adgangsadresseid, c.Storkredsnummer });
            modelBuilder.EntitySet<Supplerendebynavn>("Supplerendebynavn").EntityType
                .HasKey(c => new { c.Dagi_id });
            modelBuilder.EntitySet<Supplerendebynavntilknytning>("Supplerendebynavntilknytning").EntityType
                .HasKey(c => new { c.Adgangsadresseid, c.Dagi_id });
            modelBuilder.EntitySet<Valglandsdel>("Valglandsdel").EntityType
                .HasKey(c => new { c.Bogstav });
            modelBuilder.EntitySet<Valglandsdelstilknytning>("Valglandsdelstilknytning").EntityType
                .HasKey(c => new { c.Adgangsadresseid, c.Valglandsdelsbogstav });
            modelBuilder.EntitySet<Vask_adresse_historik>("Vask_adresse_historik").EntityType
                .HasKey(c => new { c.Rowkey });
            modelBuilder.EntitySet<Vask_husnummer_historik>("Vask_husnummer_historik").EntityType
                .HasKey(c => new { c.Rowkey });
            modelBuilder.EntitySet<Vejmidte>("Vejmidte").EntityType
                .HasKey(c => new { c.Kommunekode, c.Vejkode });
            modelBuilder.EntitySet<Vejpunkt>("Vejpunkt").EntityType
                .HasKey(c => new { c.Id });
            modelBuilder.EntitySet<Vejstykke>("Vejstykke").EntityType
                .HasKey(c => new { c.Kommunekode, c.Kode });
            modelBuilder.EntitySet<Vejstykkepostnummerrelation>("Vejstykkepostnummerrelation").EntityType
                .HasKey(c => new { c.Kommunekode, c.Vejkode, c.Postnr });
            modelBuilder.EntitySet<Zone>("Zone").EntityType
                .HasKey(c => new { c.Zone_ });
            modelBuilder.EntitySet<Zonetilknytning>("Zonetilknytning").EntityType
                .HasKey(c => new { c.Adgangsadresseid, c.Zone });

            modelBuilder.EntitySet<Dar_adresse_aktuel>("Dar_adresse_aktuel").EntityType
                .HasKey(c => new { c.Id });
            modelBuilder.EntitySet<Dar_adresse_historik>("Dar_adresse_historik").EntityType
                .HasKey(c => new { c.Rowkey });
            modelBuilder.EntitySet<Dar_adressepunkt_aktuel>("Dar_adressepunkt_aktuel").EntityType
                .HasKey(c => new { c.Id });
            modelBuilder.EntitySet<Dar_adressepunkt_historik>("Dar_adressepunkt_historik").EntityType
                .HasKey(c => new { c.Rowkey });
            modelBuilder.EntitySet<Dar_darafstemningsområde_aktuel>("Dar_darafstemningsområde_aktuel").EntityType
                .HasKey(c => new { c.Id });
            modelBuilder.EntitySet<Dar_darafstemningsområde_historik>("Dar_darafstemningsområde_historik").EntityType
                .HasKey(c => new { c.Rowkey });
            modelBuilder.EntitySet<Dar_darkommuneinddeling_aktuel>("Dar_darkommuneinddeling_aktuel").EntityType
                .HasKey(c => new { c.Id });
            modelBuilder.EntitySet<Dar_darkommuneinddeling_historik>("Dar_darkommuneinddeling_historik").EntityType
                .HasKey(c => new { c.Rowkey });
            modelBuilder.EntitySet<Dar_darmenighedsrådsafstemningsområde_aktuel>("Dar_darmenighedsrådsafstemningsområde_aktuel").EntityType
                .HasKey(c => new { c.Id });
            modelBuilder.EntitySet<Dar_darmenighedsrådsafstemningsområde_historik>("Dar_darmenighedsrådsafstemningsområde_historik").EntityType
                .HasKey(c => new { c.Rowkey });
            modelBuilder.EntitySet<Dar_darsogneinddeling_aktuel>("Dar_darsogneinddeling_aktuel").EntityType
                .HasKey(c => new { c.Id });
            modelBuilder.EntitySet<Dar_darsogneinddeling_historik>("Dar_darsogneinddeling_historik").EntityType
                .HasKey(c => new { c.Rowkey });
            modelBuilder.EntitySet<Dar_husnummer_aktuel>("Dar_husnummer_aktuel").EntityType
                .HasKey(c => new { c.Id });
            modelBuilder.EntitySet<Dar_husnummer_historik>("Dar_husnummer_historik").EntityType
                .HasKey(c => new { c.Rowkey });
            modelBuilder.EntitySet<Dar_navngivenvej_aktuel>("Dar_navngivenvej_aktuel").EntityType
                .HasKey(c => new { c.Id });
            modelBuilder.EntitySet<Dar_navngivenvej_historik>("Dar_navngivenvej_historik").EntityType
                .HasKey(c => new { c.Rowkey });
            modelBuilder.EntitySet<Dar_navngivenvejkommunedel_aktuel>("Dar_navngivenvejkommunedel_aktuel").EntityType
                .HasKey(c => new { c.Id });
            modelBuilder.EntitySet<Dar_navngivenvejkommunedel_historik>("Dar_navngivenvejkommunedel_historik").EntityType
                .HasKey(c => new { c.Rowkey });
            modelBuilder.EntitySet<Dar_navngivenvejpostnummerrelation_aktuel>("Dar_navngivenvejpostnummerrelation_aktuel").EntityType
                .HasKey(c => new { c.Id });
            modelBuilder.EntitySet<Dar_navngivenvejpostnummerrelation_historik>("Dar_navngivenvejpostnummerrelation_historik").EntityType
                .HasKey(c => new { c.Rowkey });
            modelBuilder.EntitySet<Dar_navngivenvejsupplerendebynavnrelation_aktuel>("Dar_navngivenvejsupplerendebynavnrelation_aktuel").EntityType
                .HasKey(c => new { c.Id });
            modelBuilder.EntitySet<Dar_navngivenvejsupplerendebynavnrelation_historik>("Dar_navngivenvejsupplerendebynavnrelation_historik").EntityType
                .HasKey(c => new { c.Rowkey });
            modelBuilder.EntitySet<Dar_postnummer_aktuel>("Dar_postnummer_aktuel").EntityType
                .HasKey(c => new { c.Id });
            modelBuilder.EntitySet<Dar_postnummer_historik>("Dar_postnummer_historik").EntityType
                .HasKey(c => new { c.Rowkey });
            modelBuilder.EntitySet<Dar_reserveretvejnavn_aktuel>("Dar_reserveretvejnavn_aktuel").EntityType
                .HasKey(c => new { c.Id });
            modelBuilder.EntitySet<Dar_reserveretvejnavn_historik>("Dar_reserveretvejnavn_historik").EntityType
                .HasKey(c => new { c.Rowkey });
            modelBuilder.EntitySet<Dar_supplerendebynavn_aktuel>("Dar_supplerendebynavn_aktuel").EntityType
                .HasKey(c => new { c.Id });
            modelBuilder.EntitySet<Dar_supplerendebynavn_historik>("Dar_supplerendebynavn_historik").EntityType
                .HasKey(c => new { c.Rowkey });

            modelBuilder.EntitySet<Bbr_bygning>("Bbr_bygning").EntityType
                .HasKey(c => new { c.Rowkey });
            modelBuilder.EntitySet<Bbr_bygning_aktuel>("Bbr_bygning_aktuel").EntityType
                .HasKey(c => new { c.Id });
            modelBuilder.EntitySet<Bbr_bygning_historik>("Bbr_bygning_historik").EntityType
                .HasKey(c => new { c.Rowkey });
            modelBuilder.EntitySet<Bbr_bygningpåfremmedgrund>("Bbr_bygningpåfremmedgrund").EntityType
                .HasKey(c => new { c.Rowkey });
            modelBuilder.EntitySet<Bbr_bygningpåfremmedgrund_aktuel>("Bbr_bygningpåfremmedgrund_aktuel").EntityType
                .HasKey(c => new { c.Id });
            modelBuilder.EntitySet<Bbr_bygningpåfremmedgrund_historik>("Bbr_bygningpåfremmedgrund_historik").EntityType
                .HasKey(c => new { c.Rowkey });
            modelBuilder.EntitySet<Bbr_ejendomsrelation>("Bbr_ejendomsrelation").EntityType
                .HasKey(c => new { c.Rowkey });
            modelBuilder.EntitySet<Bbr_ejendomsrelation_aktuel>("Bbr_ejendomsrelation_aktuel").EntityType
                .HasKey(c => new { c.Id });
            modelBuilder.EntitySet<Bbr_ejendomsrelation_historik>("Bbr_ejendomsrelation_historik").EntityType
                .HasKey(c => new { c.Rowkey });
            modelBuilder.EntitySet<Bbr_enhed>("Bbr_enhed").EntityType
                .HasKey(c => new { c.Rowkey });
            modelBuilder.EntitySet<Bbr_enhed_aktuel>("Bbr_enhed_aktuel").EntityType
                .HasKey(c => new { c.Id });
            modelBuilder.EntitySet<Bbr_enhed_historik>("Bbr_enhed_historik").EntityType
                .HasKey(c => new { c.Rowkey });
            modelBuilder.EntitySet<Bbr_enhedejerlejlighed>("Bbr_enhedejerlejlighed").EntityType
                .HasKey(c => new { c.Rowkey });
            modelBuilder.EntitySet<Bbr_enhedejerlejlighed_aktuel>("Bbr_enhedejerlejlighed_aktuel").EntityType
                .HasKey(c => new { c.Id });
            modelBuilder.EntitySet<Bbr_enhedejerlejlighed_historik>("Bbr_enhedejerlejlighed_historik").EntityType
                .HasKey(c => new { c.Rowkey });
            modelBuilder.EntitySet<Bbr_etage>("Bbr_etage").EntityType
                .HasKey(c => new { c.Rowkey });
            modelBuilder.EntitySet<Bbr_etage_aktuel>("Bbr_etage_aktuel").EntityType
                .HasKey(c => new { c.Id });
            modelBuilder.EntitySet<Bbr_etage_historik>("Bbr_etage_historik").EntityType
                .HasKey(c => new { c.Rowkey });
            modelBuilder.EntitySet<Bbr_fordelingaffordelingsareal>("Bbr_fordelingaffordelingsareal").EntityType
                .HasKey(c => new { c.Rowkey });
            modelBuilder.EntitySet<Bbr_fordelingaffordelingsareal_aktuel>("Bbr_fordelingaffordelingsareal_aktuel").EntityType
                .HasKey(c => new { c.Id });
            modelBuilder.EntitySet<Bbr_fordelingaffordelingsareal_historik>("Bbr_fordelingaffordelingsareal_historik").EntityType
                .HasKey(c => new { c.Rowkey });
            modelBuilder.EntitySet<Bbr_fordelingsareal>("Bbr_fordelingsareal").EntityType
                .HasKey(c => new { c.Rowkey });
            modelBuilder.EntitySet<Bbr_fordelingsareal_aktuel>("Bbr_fordelingsareal_aktuel").EntityType
                .HasKey(c => new { c.Id });
            modelBuilder.EntitySet<Bbr_fordelingsareal_historik>("Bbr_fordelingsareal_historik").EntityType
                .HasKey(c => new { c.Rowkey });
            modelBuilder.EntitySet<Bbr_grund>("Bbr_grund").EntityType
                .HasKey(c => new { c.Rowkey });
            modelBuilder.EntitySet<Bbr_grund_aktuel>("Bbr_grund_aktuel").EntityType
                .HasKey(c => new { c.Id });
            modelBuilder.EntitySet<Bbr_grund_historik>("Bbr_grund_historik").EntityType
                .HasKey(c => new { c.Rowkey });
            modelBuilder.EntitySet<Bbr_grundjordstykke>("Bbr_grundjordstykke").EntityType
                .HasKey(c => new { c.Rowkey });
            modelBuilder.EntitySet<Bbr_grundjordstykke_aktuel>("Bbr_grundjordstykke_aktuel").EntityType
                .HasKey(c => new { c.Id });
            modelBuilder.EntitySet<Bbr_grundjordstykke_historik>("Bbr_grundjordstykke_historik").EntityType
                .HasKey(c => new { c.Rowkey });
            modelBuilder.EntitySet<Bbr_opgang>("Bbr_opgang").EntityType
                .HasKey(c => new { c.Rowkey });
            modelBuilder.EntitySet<Bbr_opgang_aktuel>("Bbr_opgang_aktuel").EntityType
                .HasKey(c => new { c.Id });
            modelBuilder.EntitySet<Bbr_opgang_historik>("Bbr_opgang_historik").EntityType
                .HasKey(c => new { c.Rowkey });
            modelBuilder.EntitySet<Bbr_tekniskanlæg>("Bbr_tekniskanlæg").EntityType
                .HasKey(c => new { c.Rowkey });
            modelBuilder.EntitySet<Bbr_tekniskanlæg_aktuel>("Bbr_tekniskanlæg_aktuel").EntityType
                .HasKey(c => new { c.Id });
            modelBuilder.EntitySet<Bbr_tekniskanlæg_historik>("Bbr_tekniskanlæg_historik").EntityType
                .HasKey(c => new { c.Rowkey });

            modelBuilder.EntitySet<DAGI__Afstemningsomraader>("Dagi_Afstemningsomraader").EntityType
                .HasKey(c => new { c.Dagi_id });
            modelBuilder.EntitySet<DAGI__Kommuner>("Dagi_Kommuner").EntityType
                .HasKey(c => new { c.Dagi_id });
            modelBuilder.EntitySet<DAGI__Landsdele>("Dagi_Landsdele").EntityType
                .HasKey(c => new { c.Dagi_id });
            modelBuilder.EntitySet<DAGI__Menighedsraadsafstemningsomraader>("Dagi_Menighedsraadsafstemningsomraader").EntityType
                .HasKey(c => new { c.Dagi_id });
            modelBuilder.EntitySet<DAGI__Opstillingskredse>("Dagi_Opstillingskredse").EntityType
                .HasKey(c => new { c.Dagi_id });
            modelBuilder.EntitySet<DAGI__Politikredse>("Dagi_Politikredse").EntityType
                .HasKey(c => new { c.Dagi_id });
            modelBuilder.EntitySet<DAGI__Postnumre>("Dagi_Postnumre").EntityType
                .HasKey(c => new { c.Nr });
            modelBuilder.EntitySet<DAGI__Regioner>("Dagi_Regioner").EntityType
                .HasKey(c => new { c.Dagi_id });
            modelBuilder.EntitySet<DAGI__Retskredse>("Dagi_Retskredse").EntityType
                .HasKey(c => new { c.Dagi_id });
            modelBuilder.EntitySet<DAGI__Sogne>("Dagi_Sogne").EntityType
                .HasKey(c => new { c.Dagi_id });
            modelBuilder.EntitySet<DAGI__Steder>("Dagi_Steder").EntityType
                .HasKey(c => new { c.Id });
            modelBuilder.EntitySet<DAGI__Stednavne>("Dagi_Stednavne").EntityType
                .HasKey(c => new { c.Id });
            modelBuilder.EntitySet<DAGI__Storkredse>("Dagi_Storkredse").EntityType
                .HasKey(c => new { c.Nummer });
            modelBuilder.EntitySet<DAGI__Supplerendebynavne2>("Dagi_Supplerendebynavne2").EntityType
                .HasKey(c => new { c.Dagi_id });
            modelBuilder.EntitySet<DAGI__Valglandsdele>("Dagi_Valglandsdele").EntityType
                .HasKey(c => new { c.Bogstav });

            return modelBuilder.GetEdmModel();
        }

    }
}
