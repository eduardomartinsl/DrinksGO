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
    public class CondicaoImplementation : ICondicaoView {
        public Task<IList<Condicao>> GetAll() {
            IList<Condicao> condicao = new List<Condicao> {
                new Condicao { id = 0, ComoFazer ="Virar copo" },
                new Condicao { id = 0, ComoFazer ="Bebe meio copo" },
                new Condicao { id = 0, ComoFazer ="Bebe seno(3/8) de copo" },
                new Condicao { id = 0, ComoFazer ="Encher copo" },
                new Condicao { id = 0, ComoFazer ="Dar 1 gole" },
                new Condicao { id = 0, ComoFazer ="Dar 2 goles" },
                new Condicao { id = 0, ComoFazer ="Dar 3 goles" },
                new Condicao { id = 0, ComoFazer ="Tomar 1 shot" },
                new Condicao { id = 0, ComoFazer ="Tomar 2 shots" },
                new Condicao { id = 0, ComoFazer ="Tomar 3 shots" },
                new Condicao { id = 0, ComoFazer ="Encher outro copo de sua escolha" },
                new Condicao { id = 0, ComoFazer ="Beber o copo da direita" },
                new Condicao { id = 0, ComoFazer ="Beber o copo da esquerda" },
                new Condicao { id = 0, ComoFazer ="Beber o copo da frente" },
                new Condicao { id = 0, ComoFazer ="Beber todos os copos do jogo" },
                new Condicao { id = 0, ComoFazer ="Não beber nada" },
                new Condicao { id = 0, ComoFazer ="Não beber por 1 jogada" },
                new Condicao { id = 0, ComoFazer ="Não beber por 2 jogadas" },
                new Condicao { id = 0, ComoFazer ="Não beber por 3 jogadas" },
                new Condicao { id = 0, ComoFazer ="Não beber por 1 rodada" },
                new Condicao { id = 0, ComoFazer ="Beber a bebida quente" },

            };

            return Task.FromResult(condicao);
        }
    }
}