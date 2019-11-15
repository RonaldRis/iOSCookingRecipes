using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;

namespace SecretosDeCocinaL.Models
{
    public class RecetasRepository
    {

        //Singleton
        private static RecetasRepository _instancia;
        public static RecetasRepository Instancia { get => _instancia ??= new RecetasRepository(); }
        //Datos staticos!!
        public List<Receta> Recetas { get; set; }
        public string SelectedReceta { get; set; }


        public RecetasRepository()
        {
            Recetas = new List<Receta>
            {
                new Receta
                {
                    name="Huevo duro",
                    Pasos = new List<string>()
                    {
                        "1- Se pone agua en una olla",
                        "2- Se pone el huevo en la olla",
                        "3- Se deja hervir por 10 minutos",
                        "4- Se saca el huevo",
                        "5- Se pela el huevo",
                        "6- Se come el huevo"
                    }
                },
                new Receta
                {
                    name="Limonada",
                    Pasos = new List<string>()
                    {
                        "1- Se parten los limones",
                        "2- Se exprimen en un vaso",
                        "3- Se agrega agua",
                        "4- Se agrega sal y limon al gusto",
                        "5- Se mezcla todo",
                        "6- Se sirve y listo"
                    }
                },
                new Receta
                {
                    name="Ensalada",
                    Pasos = new List<string>()
                    {
                        "1- Se consigue verduras",
                        "2- Se lavan las verduras",
                        "3- Se pican las verduras",
                        "4- Se agrega sal y limon al gusto",
                        "5- Se sirve y listo"
                    }
                }
            };
        }
    }
}