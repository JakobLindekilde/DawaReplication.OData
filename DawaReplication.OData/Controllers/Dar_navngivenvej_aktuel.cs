using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace DawaReplication.OData.Controllers
{
    /// <summary>
    /// Table Dar_navngivenvej_aktuel Controller.
    /// </summary>
    public partial class Dar_navngivenvej_aktuelController : ControllerBase
    {
        /// <summary>The typical constructor.</summary>
        public Dar_navngivenvej_aktuelController(ODataDBContext db) : base(db) { }

        /// <summary>Returns table Dar_navngivenvej_aktuel data.</summary>
        [EnableQuery]
        public IActionResult Get()
        {
            return Ok(_db.Dar_navngivenvej_aktuel);
        }

        /// <summary>
        /// Return the table row data for primarykey key.
        /// Returns http code 204 'No Content' if the key is not in the table.
        /// </summary>
        /// <param name="key">Primary key for table as string.</param>
        [EnableQuery]
        public IActionResult Get(string key)
        {
            var row = _db.Dar_navngivenvej_aktuel.Select(x => x).FirstOrDefault(c => c.DawaPkey == key);
            return Ok(row);
        }
    }
}

