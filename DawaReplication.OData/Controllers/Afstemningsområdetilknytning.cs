using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace DawaReplication.OData.Controllers
{
    /// <summary>
    /// Table Afstemningsområdetilknytning Controller.
    /// </summary>
    public partial class AfstemningsområdetilknytningController : ControllerBase
    {
        /// <summary>The typical constructor.</summary>
        public AfstemningsområdetilknytningController(ODataDBContext db) : base(db) { }

        /// <summary>Returns table Afstemningsområdetilknytning data.</summary>
        [EnableQuery]
        public IActionResult Get()
        {
            return Ok(_db.Afstemningsområdetilknytning);
        }

        /// <summary>
        /// Return the table row data for primarykey key.
        /// Returns http code 204 'No Content' if the key is not in the table.
        /// </summary>
        /// <param name="key">Primary key for table as string.</param>
        [EnableQuery]
        public IActionResult Get(string key)
        {
            var row = _db.Afstemningsområdetilknytning.Select(x => x).FirstOrDefault(c => c.DawaPkey == key);
            return Ok(row);
        }
    }
}

