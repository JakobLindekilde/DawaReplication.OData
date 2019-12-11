using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace DawaReplication.OData.CodeGenerator
{
    public static class Program
    {

        static void Main()
        {
            using (StreamReader tablesReader = new StreamReader("EntityList.json"))
            {
                List<string> entityList = JsonConvert.DeserializeObject<List<string>>(tablesReader.ReadToEnd());
                for (int i = 0; i < entityList.Count(); i++)
                {
                    var entityName = entityList[i];
                    var file = new StringBuilder(MakeControllerFile(entityName));
                    File.WriteAllText($".\\GeneratedFiles\\{entityName}.cs", file.ToString());
                }
            }
        }

        public static string MakeControllerFile(string entityName)
        {
            if (entityName == null)
            {
                throw new ArgumentNullException(nameof(entityName));
            }

            return
               $"using Microsoft.AspNet.OData;\r\n" +
                "using Microsoft.AspNetCore.Mvc;\r\n" +
                "using System.Linq;\r\n" +
                "\r\n" +
                "namespace DawaReplication.OData.Controllers\r\n" +
                "{\r\n" +
                "    /// <summary>\r\n" +
               $"    /// Table {entityName} Controller.\r\n" +
                "    /// </summary>\r\n" +
               $"    public partial class {entityName}Controller : ControllerBase\r\n" +
                "    {\r\n" +
                "        /// <summary>The typical constructor.</summary>\r\n" +
               $"        public {entityName}Controller(ODataDBContext db) : base(db) {{ }}\r\n" +
                "\r\n" +
               $"        /// <summary>Returns table {entityName} data.</summary>\r\n" +
                "        [EnableQuery]\r\n" +
                "        public IActionResult Get()\r\n" +
                "        {\r\n" +
               $"            return Ok(_db.{entityName});\r\n" +
                "        }\r\n" +
                "\r\n" +
                "        /// <summary>\r\n" +
                "        /// Return the table row data for primarykey key.\r\n" +
                "        /// Returns http code 204 'No Content' if the key is not in the table.\r\n" +
                "        /// </summary>\r\n" +
                "        /// <param name=\"key\">Primary key for table as string.</param>\r\n" +
                "        [EnableQuery]\r\n" +
                "        public IActionResult Get(string key)\r\n" +
                "        {\r\n" +
               $"            var row = _db.{entityName}.Select(x => x).FirstOrDefault(c => c.DawaPkey == key);\r\n" +
                "            return Ok(row);\r\n" +
                "        }\r\n" +
                "    }\r\n" +
                "}\r\n" +
                "\r\n";
        }
    }
}
