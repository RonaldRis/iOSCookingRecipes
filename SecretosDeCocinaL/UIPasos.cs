using Foundation;
using SecretosDeCocinaL.Models;
using System;
using System.Collections.Generic;
using UIKit;

namespace SecretosDeCocinaL
{
    public partial class UIPasos : UITableViewController
    {

        List<string> Pasos = new List<string>();
        Receta RecetaEsta;
        public UIPasos (IntPtr handle) : base (handle)
        {
            foreach (var item in RecetasRepository.Instancia.Recetas)
            {
                if (item.name== RecetasRepository.Instancia.SelectedReceta)
                {
                    RecetaEsta = item;
                }
            }

            RecetaEsta.Pasos.ForEach(p => Pasos.Add(p));
        }


        public override nint RowsInSection(UITableView tableView, nint section)
        {
            return Pasos.Count;
        }

        public override nint NumberOfSections(UITableView tableView)
        {
            return 1;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = tableView.DequeueReusableCell("idePaso");
            cell.TextLabel.Text = Pasos[indexPath.Row];
            return cell;
        }


    }
}