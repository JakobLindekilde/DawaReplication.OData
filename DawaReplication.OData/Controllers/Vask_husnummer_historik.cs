using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace DawaReplication.OData.Controllers
{
    /// <summary>
    /// Table Vask_husnummer_historik Controller.
    /// </summary>
    public partial class Vask_husnummer_historikController : ControllerBase
    {
        /// <summary>The typical constructor.</summary>
        public Vask_husnummer_historikController(ODataDBContext db) : base(db) { }

        /// <summary>Returns table Vask_husnummer_historik data.</summary>
        [EnableQuery]
        public IActionResult Get()
        {
            return Ok(_db.Vask_husnummer_historik);
        }

        /// <summary>
        /// Return the table row data for primarykey key.
        /// Returns http code 204 'No Content' if the key is not in the table.
        /// </summary>
        /// <param name="key">Primary key for table as string.</param>
        [EnableQuery]
        public IActionResult Get(string key)
        {
            var row = _db.Vask_husnummer_historik.Select(x => x).FirstOrDefault(c => c.DawaPkey == key);
            return Ok(row);
        }
    }
}

