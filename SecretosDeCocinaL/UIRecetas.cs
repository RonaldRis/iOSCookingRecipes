using Foundation;
using SecretosDeCocinaL.Models;
using System;
using System.Collections.Generic;
using UIKit;

namespace SecretosDeCocinaL
{
    public partial class UIRecetas : UITableViewController
    {
        List<string> Nombres = new List<string>();

        public UIRecetas (IntPtr handle) : base (handle)
        {
            RecetasRepository repo = new RecetasRepository();
            RecetasRepository.Instancia.Recetas.ForEach(P => Nombres.Add(P.name));



        }




        public override nint NumberOfSections(UITableView tableView)
        {
            return 1;
        }

        public override nint RowsInSection(UITableView tableView, nint section)
        {
            return Nombres.Count;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = tableView.DequeueReusableCell("ideReceta");
            cell.TextLabel.Text = Nombres[indexPath.Row];
            return cell;
        }

        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
            RecetasRepository.Instancia.SelectedReceta = Nombres[indexPath.Row];
        }
    }
}