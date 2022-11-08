using CursoDesignPatternPT2.cap4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatternPT2.cap5
{
    public interface IVisitor
    {
        void ImprimeSoma(Soma soma);
        void ImprimeSubtracao(Subtracao subtracao);
        void ImprimeNumero(Numero numero);
        void ImprimeMultiplicacao(Multiplicacao multiplicacao);
        void ImprimeDivisao(Divisao divisao);
        void ImprimeRaizQuadrada(RaizQuadrada raizQuadrada);
    }
}
