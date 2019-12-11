using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace DawaReplication.OData.Controllers
{
    /// <summary>
    /// Table Afstemningsområde Controller.
    /// </summary>
    public partial class AfstemningsområdeController : ControllerBase
    {
        /// <summary>The typical constructor.</summary>
        public AfstemningsområdeController(ODataDBContext db) : base(db) { }

        /// <summary>Returns table Afstemningsområde data.</summary>
        [EnableQuery]
        public IActionResult Get()
        {
            return Ok(_db.Afstemningsområde);
        }

        /// <summary>
        /// Return the table row data for primarykey key.
        /// Returns http code 204 'No Content' if the key is not in the table.
        /// </summary>
        /// <param name="key">Primary key for table as string.</param>
        [EnableQuery]
        public IActionResult Get(string key)
        {
            var row = _db.Afstemningsområde.Select(x => x).FirstOrDefault(c => c.DawaPkey == key);
            return Ok(row);
        }
    }
}

