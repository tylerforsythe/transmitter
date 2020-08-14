using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace Transmitter
{
    /// <summary>
    /// Create methods for:
    /// Receiving a file in chunks: file name, chunk, chunk size, SHA2
    /// Validate a file: file name, size in bytes, SHA2
    /// (WISH LIST) Transmit a file: file name, SHA2, destination address
    /// </summary>
    public class FilesController : ApiController 
    { 
        // GET api/values 
        public IEnumerable<string> Get() {
            Console.WriteLine("Files GET");
            return new string[] { "value1", "value2" }; 
        } 

        // GET api/values/5 
        public string Get(int id) 
        { 
            return "value"; 
        } 

        // POST api/values 
        public void Post([FromBody]string value) 
        { 
        } 

        // PUT api/values/5 
        public void Put([FromBody]string value) 
        {
            Console.WriteLine($"Files PUT {value}");
        } 

        // DELETE api/values/5 
        public void Delete(int id) 
        { 
        } 
    }
}
