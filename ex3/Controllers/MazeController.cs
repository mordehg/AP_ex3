using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ex3.Models;
using Newtonsoft.Json.Linq;

namespace ex3.Controllers
{
    public class MazeController : ApiController
    {
        public ISinglePlayerModel model = new SinglePlayerModel();
        // GET: api/Maze
        /* public IEnumerable<string> Get()
         {
             return new string[] { "value1", "value2" };
         }*/

        // GET: api/Maze/name/5/8 
        // api/Maze/name?row=6&col=4
        public JObject Get(string mazeName, int row, int col)
        {
            return JObject.Parse(model.Generate(mazeName, row, col).ToJSON());
        }

        // POST: api/Maze
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Maze/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Maze/5
        public void Delete(int id)
        {
        }
    }
}
