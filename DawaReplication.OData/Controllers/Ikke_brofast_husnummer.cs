using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace DawaReplication.OData.Controllers
{
    /// <summary>
    /// Table Ikke_brofast_husnummer Controller.
    /// </summary>
    public partial class Ikke_brofast_husnummerController : ControllerBase
    {
        /// <summary>The typical constructor.</summary>
        public Ikke_brofast_husnummerController(ODataDBContext db) : base(db) { }

        /// <summary>Returns table Ikke_brofast_husnummer data.</summary>
        [EnableQuery]
        public IActionResult Get()
        {
            return Ok(_db.Ikke_brofast_husnummer);
        }

        /// <summary>
        /// Return the table row data for primarykey key.
        /// Returns http code 204 'No Content' if the key is not in the table.
        /// </summary>
        /// <param name="key">Primary key for table as string.</param>
        [EnableQuery]
        public IActionResult Get(string key)
        {
            var row = _db.Ikke_brofast_husnummer.Select(x => x).FirstOrDefault(c => c.DawaPkey == key);
            return Ok(row);
        }
    }
}

