using Microsoft.AspNet.OData;

namespace DawaReplication.OData.Controllers
{
    /// <summary>Base class for DAWA OData Controller.</summary>
    public class ControllerBase : ODataController
    {
        protected ODataDBContext _db;

        /// <summary>This constructor sets the DBContext.</summary>
        public ControllerBase(ODataDBContext db)
        {
            _db = db;
        }
    }
}
