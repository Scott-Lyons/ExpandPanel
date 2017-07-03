using System.Web.Mvc;
using ExpandPanel.Models;

namespace ExpandPanel.Controllers
{
    public class PanelExampleController : Controller
    {
        // GET: PanelExample
        public ActionResult Index()
        {
            var teamId = 1;

            return View(new Teams
            {
                new Team {Id = teamId++, Name = "Team A"},
                new Team {Id = teamId++, Name = "Team B"},
                new Team {Id = teamId++, Name = "Team C"},
                new Team {Id = teamId++, Name = "Team D"},
                new Team {Id = teamId++, Name = "Team E"},
                new Team {Id = teamId++, Name = "Team F"},
                new Team {Id = teamId++, Name = "Team G"},
                new Team {Id = teamId, Name = "Team H"},

            });
        }

        public PartialViewResult Users(int teamId)
        {
            var users = new Users
            {
                new User {Name = "Bob"},
                new User {Name = "Jerry"},
                new User {Name = "John"},
                new User {Name = "Rick"},
                new User {Name = "Pinky"},
                new User {Name = "Brain"},
                new User {Name = "Scott"},
                new User {Name = "Jean"},
                new User {Name = "Henry"},
            };
            users.TeamId = teamId;

            return PartialView("_TeamUsers", users);
        }
    }
}