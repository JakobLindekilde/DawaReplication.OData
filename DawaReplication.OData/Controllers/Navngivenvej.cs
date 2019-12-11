using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace DawaReplication.OData.Controllers
{
    /// <summary>
    /// Table Navngivenvej Controller.
    /// </summary>
    public partial class NavngivenvejController : ControllerBase
    {
        /// <summary>The typical constructor.</summary>
        public NavngivenvejController(ODataDBContext db) : base(db) { }

        /// <summary>Returns table Navngivenvej data.</summary>
        [EnableQuery]
        public IActionResult Get()
        {
            return Ok(_db.Navngivenvej);
        }

        /// <summary>
        /// Return the table row data for primarykey key.
        /// Returns http code 204 'No Content' if the key is not in the table.
        /// </summary>
        /// <param name="key">Primary key for table as string.</param>
        [EnableQuery]
        public IActionResult Get(string key)
        {
            var row = _db.Navngivenvej.Select(x => x).FirstOrDefault(c => c.DawaPkey == key);
            return Ok(row);
        }
    }
}

