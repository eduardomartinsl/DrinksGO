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
using System.Threading.Tasks;
using DrinksGO.Models;

namespace DrinksGO.Interfaces {
    public interface IFinalizacaoView {

        Task<IList<Finalizacao>> GetAll();

    }
}