using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Vidlz.Models;

namespace Vidlz.DAL
{
    public class MarkerInitializer : System.Data.Entity.DropCreateDatabaseAlways<MarkerContext>
    {
        protected override void Seed(MarkerContext context)
        {
            var Markers = new List<Marker>
            {
                new Marker{Longitude=11.325, Latitude = 46.397},
                new Marker{Longitude=9.04, Latitude = 46.727},
                new Marker{Longitude=90.04, Latitude = 6.727},
                new Marker{Longitude=0.04, Latitude = 60.727}


            };

            Markers.ForEach(s => context.Marker.Add(s));
            context.SaveChanges();
        }
    }
}