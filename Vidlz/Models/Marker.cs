using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidlz.Models
{
    public class Marker
    {
        public int Id { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
    }
}