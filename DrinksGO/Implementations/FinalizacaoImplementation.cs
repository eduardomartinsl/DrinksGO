using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using DrinksGO.Interfaces;
using DrinksGO.Models;

namespace DrinksGO.Implementations {
    public class FinalizacaoImplementation : IFinalizacaoView {

        //update futuro
        public IList<Finalizacao> GetAll() {
            IList<Finalizacao> finalizacao = new List<Finalizacao> {
                new Finalizacao{id = 0, ComoFinalizar = "Depois gritar um trecho do hino nacional"},
            };
            return finalizacao;
        }
    }

    /*
     
    http://dontpad.com/eudueudu

     
     */

}