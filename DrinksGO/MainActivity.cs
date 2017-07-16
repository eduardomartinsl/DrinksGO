using Android.App;
using Android.Widget;
using Android.OS;
using DrinksGO.Implementations;
using System.Collections.Generic;
using DrinksGO.Models;
using System;

namespace DrinksGO {
    [Activity(Label = "DrinksGO", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity {

        private List<Sujeito> listaSujeitos = new List<Sujeito>();
        private List<Condicao> listaCondicao = new List<Condicao>();
        private List<AcaoBebida> listaAcaoBebida = new List<AcaoBebida>();
        private List<Finalizacao> listaFinalizacao = new List<Finalizacao>();
        
        private TextView sujeitoTxtView;
        private TextView acaoBebidaTxtView;
        private TextView condicaoTxtView;
        private TextView finalizacaoTxtView;
        
        protected override void OnCreate(Bundle bundle) {
            base.OnCreate(bundle);
            
            SetContentView(Resource.Layout.Main);

            listaSujeitos.AddRange(new SujeitoImplementation().GetAll());
            listaCondicao.AddRange(new CondicaoImplementation().GetAll());
            listaAcaoBebida.AddRange(new AcaoBebidaImplementation().GetAll());
            listaFinalizacao.AddRange(new FinalizacaoImplementation().GetAll());
            
            sujeitoTxtView = FindViewById<TextView>(Resource.Id.TextViewQuem);
            acaoBebidaTxtView = FindViewById<TextView>(Resource.Id.TextViewOQue);
            condicaoTxtView = FindViewById<TextView>(Resource.Id.TextViewComo);
            finalizacaoTxtView = FindViewById<TextView>(Resource.Id.TextViewFazendo);

            sujeitoTxtView.Click += SujeitoTxtView_Click;
            acaoBebidaTxtView.Click += AcaoBebidaTxtView_Click;
            condicaoTxtView.Click += CondicaoTxtView_Click;
            finalizacaoTxtView.Click += FinalizacaoTxtView_Click;
        }

        private void FinalizacaoTxtView_Click(object sender, EventArgs e) {
            Random r = new Random();
            finalizacaoTxtView.Text = listaFinalizacao[r.Next(0, listaFinalizacao.Count)].ComoFinalizar;

        }

        private void CondicaoTxtView_Click(object sender, EventArgs e) {
            Random r = new Random();
            condicaoTxtView.Text = listaCondicao[r.Next(0, listaCondicao.Count)].ComoFazer;
        }

        private void AcaoBebidaTxtView_Click(object sender, EventArgs e) {
            Random r = new Random();
            acaoBebidaTxtView.Text = listaAcaoBebida[r.Next(0, listaAcaoBebida.Count)].OQueFazer;
        }

        private void SujeitoTxtView_Click(object sender, System.EventArgs e) {
            Random r = new Random();
            sujeitoTxtView.Text = listaSujeitos[r.Next(0, listaSujeitos.Count)].Quem;
        }
    }
}

