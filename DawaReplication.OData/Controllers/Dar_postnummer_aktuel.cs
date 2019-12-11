using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace DawaReplication.OData.Controllers
{
    /// <summary>
    /// Table Dar_postnummer_aktuel Controller.
    /// </summary>
    public partial class Dar_postnummer_aktuelController : ControllerBase
    {
        /// <summary>The typical constructor.</summary>
        public Dar_postnummer_aktuelController(ODataDBContext db) : base(db) { }

        /// <summary>Returns table Dar_postnummer_aktuel data.</summary>
        [EnableQuery]
        public IActionResult Get()
        {
            return Ok(_db.Dar_postnummer_aktuel);
        }

        /// <summary>
        /// Return the table row data for primarykey key.
        /// Returns http code 204 'No Content' if the key is not in the table.
        /// </summary>
        /// <param name="key">Primary key for table as string.</param>
        [EnableQuery]
        public IActionResult Get(string key)
        {
            var row = _db.Dar_postnummer_aktuel.Select(x => x).FirstOrDefault(c => c.DawaPkey == key);
            return Ok(row);
        }
    }
}

