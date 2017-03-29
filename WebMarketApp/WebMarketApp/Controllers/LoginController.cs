using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Neo4j.Driver.V1;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebMarketApp.Controllers
{
    public class LoginController : Controller
    {
        // GET: /<controller>/

        //Método de conexión a Neo4j
        public void Neo4jConnector()
        {
            using (var driver = GraphDatabase.Driver("bolt://localhost:7687", AuthTokens.Basic("neo4j", "neo4j")))
            using (var session = driver.Session()) 
            {

            };
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
