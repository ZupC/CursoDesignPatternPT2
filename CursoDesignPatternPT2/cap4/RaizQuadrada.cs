using CursoDesignPatternPT2.cap5;

namespace CursoDesignPatternPT2.cap4
{
    public class RaizQuadrada : IExpressao
    {
        public IExpressao Expressao { get; private set; }

        public RaizQuadrada(IExpressao e)
        {
            this.Expressao = e;
        }

        public int Avalia()
        {
            return (int) Math.Sqrt(Expressao.Avalia());
        }
        public void Aceita(IVisitor visitor)
        {
            visitor.ImprimeRaizQuadrada(this);
        }
    }
}