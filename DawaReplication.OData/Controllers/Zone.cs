using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace DawaReplication.OData.Controllers
{
    /// <summary>
    /// Table Zone Controller.
    /// </summary>
    public partial class ZoneController : ControllerBase
    {
        /// <summary>The typical constructor.</summary>
        public ZoneController(ODataDBContext db) : base(db) { }

        /// <summary>Returns table Zone data.</summary>
        [EnableQuery]
        public IActionResult Get()
        {
            return Ok(_db.Zone);
        }

        /// <summary>
        /// Return the table row data for primarykey key.
        /// Returns http code 204 'No Content' if the key is not in the table.
        /// </summary>
        /// <param name="key">Primary key for table as string.</param>
        [EnableQuery]
        public IActionResult Get(string key)
        {
            var row = _db.Zone.Select(x => x).FirstOrDefault(c => c.DawaPkey == key);
            return Ok(row);
        }
    }
}

