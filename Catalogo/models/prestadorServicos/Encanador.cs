﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo.models.prestadorServicos
{
    class Encanador : PrestadorDeServicos
    {

        public static List<Encanador> listaEncanadores = new List<Encanador>();

        public override string ToString()
        {
            return $"Categoria: Encanador\nNome: {this.nome}\n CPF: {this.cpf}\n\n";
        }

    }
}
