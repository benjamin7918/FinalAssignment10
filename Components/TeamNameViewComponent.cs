using FinalAssignment10.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalAssignment10.Components
{
    public class TeamNameViewComponent : ViewComponent 
    {
        private BowlingLeagueContext context;
        public TeamNameViewComponent(BowlingLeagueContext ctx)
        {
            context = ctx;
        }
        public IViewComponentResult Invoke()
        {
            //This is where I do the viewbag to pass the teamname to be highlighted
            ViewBag.SelectedType = RouteData?.Values["teamname"];

            return View(context.Teams
                .Distinct()
                .OrderBy(x => x));
        }
    }
}
