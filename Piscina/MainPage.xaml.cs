namespace Piscina;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

    private void OnLoginButtonClicked(object sender, EventArgs e)
    {
        // Lógica de validação do login
        string username = UsernameEntry.Text;
        string password = PasswordEntry.Text;

        if (IsValidLogin(username, password))
        {
            // Redirecionar para a próxima página
            // Exemplo:
            Navigation.PushAsync(new VisualTurma());
        }
        else
        {
            // Exibir mensagem de erro de login
            DisplayAlert("Erro", "Usuário ou senha inválidos", "OK");
        }
    }

    private bool IsValidLogin(string username, string password)
    {
        // Lógica de validação do login
        // Aqui você pode implementar sua própria lógica de autenticação
        // Por exemplo, consultar um serviço de autenticação, verificar em um banco de dados, etc.
        // Este é apenas um exemplo simples para ilustrar o conceito
        return username == "usuario" && password == "senha";
    }

    private void PaginaEnviar(object sender, EventArgs e)
    {
        Navigation.PushAsync(new SignIn());
    }

    private void OnLabelTapped(Object sender, EventArgs e)
    {
        Navigation.PushAsync(new SignIn());
    }


}

