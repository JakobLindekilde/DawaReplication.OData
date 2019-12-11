using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace DawaReplication.OData.Controllers
{
    /// <summary>
    /// Table Dar_husnummer_aktuel Controller.
    /// </summary>
    public partial class Dar_husnummer_aktuelController : ControllerBase
    {
        /// <summary>The typical constructor.</summary>
        public Dar_husnummer_aktuelController(ODataDBContext db) : base(db) { }

        /// <summary>Returns table Dar_husnummer_aktuel data.</summary>
        [EnableQuery]
        public IActionResult Get()
        {
            return Ok(_db.Dar_husnummer_aktuel);
        }

        /// <summary>
        /// Return the table row data for primarykey key.
        /// Returns http code 204 'No Content' if the key is not in the table.
        /// </summary>
        /// <param name="key">Primary key for table as string.</param>
        [EnableQuery]
        public IActionResult Get(string key)
        {
            var row = _db.Dar_husnummer_aktuel.Select(x => x).FirstOrDefault(c => c.DawaPkey == key);
            return Ok(row);
        }
    }
}

