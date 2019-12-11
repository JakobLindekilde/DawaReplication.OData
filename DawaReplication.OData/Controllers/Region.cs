using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace DawaReplication.OData.Controllers
{
    /// <summary>
    /// Table Region Controller.
    /// </summary>
    public partial class RegionController : ControllerBase
    {
        /// <summary>The typical constructor.</summary>
        public RegionController(ODataDBContext db) : base(db) { }

        /// <summary>Returns table Region data.</summary>
        [EnableQuery]
        public IActionResult Get()
        {
            return Ok(_db.Region);
        }

        /// <summary>
        /// Return the table row data for primarykey key.
        /// Returns http code 204 'No Content' if the key is not in the table.
        /// </summary>
        /// <param name="key">Primary key for table as string.</param>
        [EnableQuery]
        public IActionResult Get(string key)
        {
            var row = _db.Region.Select(x => x).FirstOrDefault(c => c.DawaPkey == key);
            return Ok(row);
        }
    }
}

