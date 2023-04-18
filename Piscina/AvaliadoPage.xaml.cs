
using Piscina.Models;

namespace Piscina;

public partial class AvaliadoPage : ContentPage
{
    private Avaliado aluno;
    private Modelo modelo;
	public AvaliadoPage()
	{
		InitializeComponent();
        Objetivo ob2 = new Objetivo("Executar corretamente a pernada", 2);
        List<Objetivo> list2 = new List<Objetivo>() { ob2 };
        Categoria c2 = new Categoria("Costas", list2);
        List<Categoria> listc2 = new List<Categoria>() { c2 };
        FichaAvaliacao f2 = new FichaAvaliacao(listc2);

        //modelo = new Modelo(aluno, listc2);
        //this.BindingContext = aluno;
        listContacts.ItemsSource = listc2;


    }

    public AvaliadoPage(object recebido)
    {
        InitializeComponent();
        aluno = (Avaliado)recebido;

        Objetivo ob1 = new Objetivo("Dominio da Respiracao(inspira��o/expira��o) automatizado", 3);
        List<Objetivo> l1 = new List<Objetivo> { ob1 };
        Categoria c1 = new Categoria("Respira��o", l1);

        Objetivo ob2 = new Objetivo("Tem um correto alinhamento lateral e horizontal nas diversas a��es motoras. Posi��o Hidrodin�mica Fundamental", 3);
        List<Objetivo> l2 = new List<Objetivo> { ob2 };
        Categoria c2 = new Categoria("Alinhamento", l2);

        Objetivo ob3 = new Objetivo("Executa batimento de pernas dorsal associado ao movimento alternado de bra�os/inspira��o", 3);
        Objetivo ob4 = new Objetivo("Entrada correta dos membros superiores", 3);
        Objetivo ob5 = new Objetivo("Entrada corretamente a pernada", 2);
        Objetivo ob6 = new Objetivo("Execu��o de movimentos propulsivos de pernas e bra�os continuo( nado continuo)", 2);
        List<Objetivo> l3 = new List<Objetivo> { ob3, ob4, ob5, ob6 };
        Categoria c3 = new Categoria("Costas", l3);

        Objetivo ob7 = new Objetivo("Boa postura nos varios planos", 3);
        Objetivo ob8 = new Objetivo("Entrada correta dos membros superiores coordenado com respira��o bilateral", 3);
        Objetivo ob9 = new Objetivo("Executa corretamente a pernada", 2);
        Objetivo ob10 = new Objetivo("Execu��o de movimentos propulsivos de pernas e bra�os continuo( nado continuo)", 2);
        List<Objetivo> l4 = new List<Objetivo> { ob7, ob8, ob9, ob10 };
        Categoria c4 = new Categoria("Crol", l4);

        Objetivo ob11 = new Objetivo("Da parede, com deslize, com batimento dos p�s,de cabe�a (inicio do ensino da partida de Crol)", 3);
        List<Objetivo> l5 = new List<Objetivo> { ob11 };
        Categoria c5 = new Categoria("Saltos", l5);

        Objetivo ob12 = new Objetivo("N�o corre no cais da piscina, toma banho antes de entrar, arruma o seu material, brinca com seguran�a", 3);
        List<Objetivo> l6 = new List<Objetivo> { ob12 };
        Categoria c6 = new Categoria("Seguran�a e higiene", l6);

        Objetivo ob13 = new Objetivo("Espirito de sociabiliza��o e desportivo. Respeita as regras da aula, os colegas e o Professor. � participante na aula", 3);
        List<Objetivo> l7 = new List<Objetivo> { ob13 };
        Categoria c7 = new Categoria("Socio Efetivo", l7);

        List<Categoria> lc1 = new List<Categoria> { c1, c2, c3, c4, c5, c6, c7 };
        FichaAvaliacao f3 = new FichaAvaliacao(lc1);


        modelo = new Modelo(aluno, lc1);
        listContacts.ItemsSource = lc1;
    }

    private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        if (e.Item is Categoria categoria)
        {
            //Enviar a categoria do aluno para ser alterada
            Categoria c1 = aluno.devolverCategoria(categoria);
            await Navigation.PushAsync(new NotaFinalPage(c1));
        }

    }
}