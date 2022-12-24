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

namespace _3280_Assignment_5
{
    /// <summary>
    /// Interaction logic for GameWindow.xaml
    /// </summary>
    public partial class GameWindow : Window
    {
        //MainWindow initializer 
        MainWindow MainWindowForm;

        //FinalWindow initializer
        FinalWindow FinalWindowForm; 

        //User initializer
        User UserForm;

        //Game initializer
        Game GameForm;
        public GameWindow()
        {
            InitializeComponent();
            Application.Current.ShutdownMode = ShutdownMode.OnGameWindowClose;

            //MainWindow initializer
           // MainWindowForm = new MainWindow();
            //FinalWindowForm = new FinalWindow(); 
        }

        /// <summary>
        /// When start button is clicked, start game, timer, hide start button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void start_btn_Click(object sender, RoutedEventArgs e)
        {
            //GameForm.startGame(GameForm.op);
            //start_btn.Visibility = Visibility.Hidden; 
        }

        /// <summary>
        /// If pressed, hide game window and show main window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void cancel_btn_Click(object sender, RoutedEventArgs e)
        {
            //this.Hide(); 
           // MainWindowForm.ShowDialog(); 
        }

        /// <summary>
        /// Send answer over to Game
        /// Display label with correct or incorrect
        /// Load new question or hide window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void submit_ans_btn_Click(object sender, RoutedEventArgs e)
        {
           // int stud_ans = int.Parse(answer_txt.Text); 

          // if(GameForm.isCorrect(stud_ans))
            //{
              //  correct_lbl.Visibility = Visibility.Visible; 
            //} else
            //{
              //  incorrect_lbl.Visibility = Visibility.Visible; 
            //}
            
            //Start the next round
           // GameForm.generateRound(GameForm.op); 
        }

        ///<summary>
        ///Close game window, open final window
        ///</summary>
        ///

        public void end_game()
        {
            //this.Hide(); 
            //FinalWindowForm.ShowDialog(); 
        }


    }
}
