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
    public class AcaoBebidaImplementation : IAcaoBebidaView {
        public IList<AcaoBebida> GetAll() {
            IList<AcaoBebida> acaoBebida = new List<AcaoBebida> {
                new AcaoBebida {id = 0, OQueFazer="Sem encostostar a boca no copo" },
                new AcaoBebida {id = 0, OQueFazer="Fazendo carinho no jogador a esquerda" },
                new AcaoBebida {id = 0, OQueFazer="Fazendo carinho no jogador a direita" },
                new AcaoBebida {id = 0, OQueFazer="Rebolando a bunda" },
                new AcaoBebida {id = 0, OQueFazer="Com a cabeça na mesa" },
                new AcaoBebida {id = 0, OQueFazer="Com o dedo dentro no nariz" },
                new AcaoBebida {id = 0, OQueFazer="Prendendo a respiração com a mão" },
                new AcaoBebida {id = 0, OQueFazer="Fazendo careta" },
                new AcaoBebida {id = 0, OQueFazer="Seduzindo o jogador a direita" },
                new AcaoBebida {id = 0, OQueFazer="Seduzindo o jogador a esquerda" },
                new AcaoBebida {id = 0, OQueFazer="Seduzindo o jogador a frente" },
                new AcaoBebida {id = 0, OQueFazer="Recebendo cócegas de 1 jogador" },
                new AcaoBebida {id = 0, OQueFazer="Recebendo cócegas de 2 jogadores" },
                new AcaoBebida {id = 0, OQueFazer="Recebendo cócegas de 3 jogadores" },
                new AcaoBebida {id = 0, OQueFazer="Apertando a bunda do jogador a direita" },
                new AcaoBebida {id = 0, OQueFazer="Apertando a bunda do jogador a esquerda" },
                new AcaoBebida {id = 0, OQueFazer="Apertando a própria bunda" },
            };
            return acaoBebida;
        }
    }
}