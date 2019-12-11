using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace DawaReplication.OData.Controllers
{
    /// <summary>
    /// Table Menighedsrådsafstemningsområde Controller.
    /// </summary>
    public partial class MenighedsrådsafstemningsområdeController : ControllerBase
    {
        /// <summary>The typical constructor.</summary>
        public MenighedsrådsafstemningsområdeController(ODataDBContext db) : base(db) { }

        /// <summary>Returns table Menighedsrådsafstemningsområde data.</summary>
        [EnableQuery]
        public IActionResult Get()
        {
            return Ok(_db.Menighedsrådsafstemningsområde);
        }

        /// <summary>
        /// Return the table row data for primarykey key.
        /// Returns http code 204 'No Content' if the key is not in the table.
        /// </summary>
        /// <param name="key">Primary key for table as string.</param>
        [EnableQuery]
        public IActionResult Get(string key)
        {
            var row = _db.Menighedsrådsafstemningsområde.Select(x => x).FirstOrDefault(c => c.DawaPkey == key);
            return Ok(row);
        }
    }
}

