using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace DawaReplication.OData.Controllers
{
    /// <summary>
    /// Table Opstillingskreds Controller.
    /// </summary>
    public partial class OpstillingskredsController : ControllerBase
    {
        /// <summary>The typical constructor.</summary>
        public OpstillingskredsController(ODataDBContext db) : base(db) { }

        /// <summary>Returns table Opstillingskreds data.</summary>
        [EnableQuery]
        public IActionResult Get()
        {
            return Ok(_db.Opstillingskreds);
        }

        /// <summary>
        /// Return the table row data for primarykey key.
        /// Returns http code 204 'No Content' if the key is not in the table.
        /// </summary>
        /// <param name="key">Primary key for table as string.</param>
        [EnableQuery]
        public IActionResult Get(string key)
        {
            var row = _db.Opstillingskreds.Select(x => x).FirstOrDefault(c => c.DawaPkey == key);
            return Ok(row);
        }
    }
}

