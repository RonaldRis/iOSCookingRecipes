using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;

namespace SecretosDeCocinaL.Models
{
    public class Receta
    {
        public string name { get; set; }
        public List<string> Pasos { get; set; }

    }
}