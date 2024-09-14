using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SIGEN.View
{
    /// <summary>
    /// Lógica de interacción para LoginWindow.xaml
    /// </summary>

    internal class User
    {
        // Documento en string porque un documento puede superar el límite de valor de Int16 e Int32
        public string Document { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Pass { get; set; }
        public string Role { get; set; }
    }

    public partial class LoginWindow : Window
    {
        private readonly List<User> Users;
        public LoginWindow()
        {
            InitializeComponent();

            // Definir lista de usuarios para el sistema simulado de login de la primera entrega
            Users = new List<User>
            {
                new User { Document = "57246784", Name = "Jairo", LastName = "Severo", Role = "IT", Pass = "jairosevero1" },
                new User { Document = "55956933", Name = "Facundo", LastName = "Charquero", Role = "Administrativo", Pass = "facucharquero2" },
                new User { Document = "56566779", Name = "Pablo", LastName = "Suarez", Role = "Entrenador", Pass = "psuarez223" },
                new User { Document = "18668428", Name = "Carolina", LastName = "Beltrami", Role = "Cliente_Fisioterapia", Pass = "carobeltra1" },
                new User { Document = "2358775210", Name = "Manuel", LastName = "Strogonov", Role = "Cliente_Deportista", Pass = "manuGonzales5" }
            };
        }

        // Lógica de manejo de inicios de sesión (Creada para manejo más limpio de login)
        private void LoginManagement()
        {
            bool HasAuthenticated = Authenticate();

            if (HasAuthenticated)
            {
                string Document = txtUser.Text;
                User User = Users.FirstOrDefault(user => user.Document == Document);

                Screens(User);
            }
        }
        
        // Lógica de pantallas según rol
        private void Screens(User user)
        {
            switch (user.Role)
            {
                case "IT":
                    ITWindow ItWindow = new ITWindow();
                    ItWindow.Show();
                    this.Close();
                    break;

                case "Administrativo":
                    AdminWindow AdminWindow = new AdminWindow();
                    AdminWindow.Show();
                    this.Close();
                    break;

                case "Entrenador":
                    TrainerWindow TrainerWindow = new TrainerWindow();
                    TrainerWindow.Show();
                    this.Close();
                    break;

                case "Cliente_Fisioterapia":
                    FisiotherapyWindow FisiotherapyWindow = new FisiotherapyWindow();
                    FisiotherapyWindow.Show();
                    this.Close();
                    break;

                case "Cliente_Deportista":
                    SportsmanWindow SportsmanWindow = new SportsmanWindow();
                    SportsmanWindow.Show();
                    this.Close();
                    break;

                default:
                    _ = MessageBox.Show("Rol de usuario inválido. Contacta al equipo de IT.");
                    break;
            }
        }

        // Lógica de Autenticación de usuario
        private bool Authenticate()
        {
            string document = txtUser.Text;
            string password = txtPass.Password;

            if(document.Length == 0 || password.Length == 0)
            {
                _ = MessageBox.Show("Los campos de documento y contraseña no pueden estar vacíos.");
                return false;
            }
            else
            {
                User findUser = Users.FirstOrDefault(user => user.Document == document);

                if (findUser != null && findUser.Pass == password)
                {
                    return true;
                }
                else
                {
                    _ = MessageBox.Show("Documento o contraseña inválida.");
                    return false;
                }
            }
        }
        
        // Función para prevenir que el usuario ponga letras en lugar de números en el campo de usuario
        private bool TextAllowed(string text)
        {
            return text.All(char.IsDigit);
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            // Poder arrastrar la ventana
            if(e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        // Iniciar sesión al presionar enter
        private void Input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                LoginManagement();
            }
        }

        private void BtnMinimize_Click(object sender, RoutedEventArgs e)
        {
            // Minimizar la ventana
            WindowState = WindowState.Minimized;
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            // Cerrar la app
            Application.Current.Shutdown();
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            LoginManagement();
        }

        private void TxtUser_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            // Verificar que el textBox tenga solo números y no exceda los 10 caracteres
            if (!TextAllowed(e.Text) || textBox.Text.Length >= 10)
            {
                e.Handled = true; // Prevenir la escritura
            }
        }
    }
}
