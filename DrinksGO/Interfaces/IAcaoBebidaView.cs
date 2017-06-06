using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using DrinksGO.Models;
using System.Threading.Tasks;

namespace DrinksGO.Interfaces {
    public interface IAcaoBebidaView {

        Task<IList<AcaoBebida>> GetAll();

    }
}