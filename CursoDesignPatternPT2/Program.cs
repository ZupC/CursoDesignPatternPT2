using CursoDesignPatternPT2;
using CursoDesignPatternPT2.cap1;
using CursoDesignPatternPT2.cap2;
using CursoDesignPatternPT2.cap3;
using CursoDesignPatternPT2.cap4;
using CursoDesignPatternPT2.cap6;
using CursoDesignPatternPT2.cap7;
using CursoDesignPatternPT2.cap8;
using CursoDesignPatternPT2.cap9;
using System.Data;
using System.Data.SqlClient;
using System.Xml.Serialization;

namespace CursoDesignPatternsPT2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region cap 2
            //NotasMusicais notas = new NotasMusicais();
            //IList<INota> musica = new List<INota>()
            //{
            //    notas.Pega("do"),
            //    notas.Pega("re"),
            //    notas.Pega("mi"),
            //    notas.Pega("fa"),
            //    notas.Pega("fa"),
            //    notas.Pega("fa"),
            //    notas.Pega("pausa"),

            //    notas.Pega("do"),
            //    notas.Pega("re"),
            //    notas.Pega("do"),
            //    notas.Pega("re"),
            //    notas.Pega("re"),
            //    notas.Pega("re"),
            //    notas.Pega("pausa"),

            //    notas.Pega("do"),
            //    notas.Pega("sol"),
            //    notas.Pega("fa"),
            //    notas.Pega("mi"),
            //    notas.Pega("mi"),
            //    notas.Pega("mi"),
            //    notas.Pega("pausa"),

            //    notas.Pega("do"),
            //    notas.Pega("re"),
            //    notas.Pega("mi"),
            //    notas.Pega("fa"),
            //    notas.Pega("fa"),
            //    notas.Pega("fa")
            //};
            //Piano piano = new Piano();
            //piano.Toca(musica);
            #endregion

            #region cap 3
            //Historico historico = new Historico();

            //Contrato contrato = new Contrato(DateTime.Now, "Mauricio", TipoContrato.Novo);
            //historico.Adiciona(contrato.SalvaEstado());

            //contrato.Avanca();
            //historico.Adiciona(contrato.SalvaEstado());

            //contrato.Avanca();
            //historico.Adiciona(contrato.SalvaEstado());

            //contrato.Avanca();
            //historico.Adiciona(contrato.SalvaEstado());
            #endregion

            #region cap 4/5
            IExpressao esquerda = new Subtracao(new Numero(10), new Numero(5));
            IExpressao direita = new Soma(new Numero(2), new Numero(10));

            IExpressao conta = new Soma(esquerda, direita);
            #endregion

            #region cap 6

            //IEnviador enviador = new EnviaPorEmail();
            //IMensagem mensagem = new MensagemAdministrativa("victor");
            //mensagem.Enviador = enviador;

            //mensagem.Envia();

            //IEnviador enviador = new EnviaPorSMS();
            //IMensagem mensagem = new MensagemCliente("mauricio");
            //mensagem.Enviador = enviador;

            //mensagem.Envia();
            #endregion

            #region cap 7
            //Pedido pedido1 = new Pedido("Mauricio", 150.0);
            //Pedido pedido2 = new Pedido("Marcelo", 250.0);

            //FilaDeTrabalho fila = new FilaDeTrabalho();

            //fila.Adiciona(new PagaPedido(pedido1));
            //fila.Adiciona(new PagaPedido(pedido2));
            //fila.Adiciona(new FinalizaPedido(pedido1));

            //fila.Processa();
            #endregion

            #region cap 8 
            //Cliente cliente = new Cliente();
            //cliente.Nome = "victor";
            //cliente.Endereco = "Rua Vergueiro";
            //cliente.DataDeNascimento = DateTime.Now;

            //GeradorDeXml gerador = new GeradorDeXml();
            //String xml = gerador.GeraXml(cliente);
            #endregion

            #region cap 9
            EmpresaFacade fachada = new EmpresaFacadeSingleton().Instancia;
            #endregion
        }
    }
}