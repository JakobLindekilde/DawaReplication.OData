using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace DawaReplication.OData.Controllers
{
    /// <summary>
    /// Table Bbr_fordelingaffordelingsareal_historik Controller.
    /// </summary>
    public partial class Bbr_fordelingaffordelingsareal_historikController : ControllerBase
    {
        /// <summary>The typical constructor.</summary>
        public Bbr_fordelingaffordelingsareal_historikController(ODataDBContext db) : base(db) { }

        /// <summary>Returns table Bbr_fordelingaffordelingsareal_historik data.</summary>
        [EnableQuery]
        public IActionResult Get()
        {
            return Ok(_db.Bbr_fordelingaffordelingsareal_historik);
        }

        /// <summary>
        /// Return the table row data for primarykey key.
        /// Returns http code 204 'No Content' if the key is not in the table.
        /// </summary>
        /// <param name="key">Primary key for table as string.</param>
        [EnableQuery]
        public IActionResult Get(string key)
        {
            var row = _db.Bbr_fordelingaffordelingsareal_historik.Select(x => x).FirstOrDefault(c => c.DawaPkey == key);
            return Ok(row);
        }
    }
}
