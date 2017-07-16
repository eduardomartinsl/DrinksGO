using System.Collections.Generic;
using System.Threading.Tasks;
using DrinksGO.Interfaces;
using DrinksGO.Models;
using System.Collections;
using System;
using System.Linq;

namespace DrinksGO.Implementations {
    class SujeitoImplementation : ISujeitoView {
        public IList<Sujeito> GetAll() {

                IList < Sujeito > sujeito = new List<Sujeito> {
                new Sujeito { id = 0, Quem="Voc�" },
                new Sujeito { id = 0, Quem="Voc� e mais um jogador" },
                new Sujeito { id = 0, Quem="Todos menos voc�" },
                new Sujeito { id = 0, Quem="Um jogador de sua escolha" },
                new Sujeito { id = 0, Quem="Dois jogadores de sua escolha" },
                new Sujeito { id = 0, Quem="Seu crush" },
                new Sujeito { id = 0, Quem="O Jogador a sua direita" },
                new Sujeito { id = 0, Quem="O Jogador a sua esquerda" },
                new Sujeito { id = 0, Quem="O jogador a sua frente" },
                new Sujeito { id = 0, Quem="Todos os homens" },
                new Sujeito { id = 0, Quem="Todas as mulheres" },
                new Sujeito { id = 0, Quem="Todas as gays" },
                new Sujeito { id = 0, Quem="Todos com tatuagem" },
                new Sujeito { id = 0, Quem="Todos sem tatuagem" },
                new Sujeito { id = 0, Quem="Todos com roupa �ntima clara" },
                new Sujeito { id = 0, Quem="Todos com roupa �ntima escura" },
                new Sujeito { id = 0, Quem="Todos sem roupa �ntima" },
                new Sujeito { id = 0, Quem="Todos de uniforme" },
                new Sujeito { id = 0, Quem="Todos de meias brancas" },
                new Sujeito { id = 0, Quem="Todos de cabelo pintado" },
                new Sujeito { id = 0, Quem="Todos de sapato aberto" },
                new Sujeito { id = 0, Quem="Todos de �culos" },
                new Sujeito { id = 0, Quem="Todos os comunistas" }
            };
            return sujeito;
        }
    }
}