using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace DawaReplication.OData.Controllers
{
    /// <summary>
    /// Table Bbr_ejendomsrelation_aktuel Controller.
    /// </summary>
    public partial class Bbr_ejendomsrelation_aktuelController : ControllerBase
    {
        /// <summary>The typical constructor.</summary>
        public Bbr_ejendomsrelation_aktuelController(ODataDBContext db) : base(db) { }

        /// <summary>Returns table Bbr_ejendomsrelation_aktuel data.</summary>
        [EnableQuery]
        public IActionResult Get()
        {
            return Ok(_db.Bbr_ejendomsrelation_aktuel);
        }

        /// <summary>
        /// Return the table row data for primarykey key.
        /// Returns http code 204 'No Content' if the key is not in the table.
        /// </summary>
        /// <param name="key">Primary key for table as string.</param>
        [EnableQuery]
        public IActionResult Get(string key)
        {
            var row = _db.Bbr_ejendomsrelation_aktuel.Select(x => x).FirstOrDefault(c => c.DawaPkey == key);
            return Ok(row);
        }
    }
}

