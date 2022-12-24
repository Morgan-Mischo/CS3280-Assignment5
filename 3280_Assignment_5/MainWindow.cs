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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _3280_Assignment_5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //GameWindow initializer
        GameWindow GameWindowForm;

        //User initializer
        User UserForm;

        //Game initializer
        Game GameForm; 

        public MainWindow()
        {
            InitializeComponent();
            Application.Current.ShutdownMode = ShutdownMode.OnMainWindowClose;

            //GameWindow initializer 
            GameWindowForm = new GameWindow();
        }

        /// <summary>
        /// Check if everything is filled out
        /// Call send_info method if it is
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void begin_game_btn_Click(object sender, RoutedEventArgs e)
        {
            send_info(); 

            //Open GameWindow
            this.Hide();
            GameWindowForm.ShowDialog(); 
        }

        public void check_info()
        {
            if()
        }

        /// <summary>
        /// Send info to User and Game upon pressing Begin Game
        /// </summary>
        /// 
        public void send_info()
        {
            string name = name_txt.Text;
            int age = int.Parse(age_txt.Text);

            //Initialize the user with the name and age from the form
            UserForm = new User(name, age);

            //Initialize a new game
            if (add_btn.IsChecked == true)
            {
                GameForm.op = "add"; 
            }
            else if (subtract_btn.IsChecked == true)
            {
                GameForm.op = "subtract";

            }
            else if (multiply_btn.IsChecked == true)
            {
                GameForm.op = "multiply";
            }
            else if (divide_btn.IsChecked == true)
            {
                GameForm.op = "divide";
            }
        }

    }
}
