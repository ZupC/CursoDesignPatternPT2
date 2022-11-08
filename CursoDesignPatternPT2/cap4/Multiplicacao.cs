using CursoDesignPatternPT2.cap5;

namespace CursoDesignPatternPT2.cap4
{
    public class Multiplicacao : IExpressao
    {
        public IExpressao Esquerda { get; private set; }
        public IExpressao Direita { get; private set; }

        public Multiplicacao(IExpressao esquerda, IExpressao direita)
        {
            this.Esquerda = esquerda;
            this.Direita = direita;
        }

        public int Avalia()
        {
            int resultadoDaEsquerda = Esquerda.Avalia();
            int resultadoDaDireita = Direita.Avalia();
            return resultadoDaEsquerda * resultadoDaDireita;
        }

        public void Aceita(IVisitor visitor)
        {
            visitor.ImprimeMultiplicacao(this);
        }
    }
}