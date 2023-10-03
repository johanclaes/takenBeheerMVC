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
using takenbeheer_dal;
using takenbeheer_models;

namespace takenBeheer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private List<ToDoTaak> _toDoTasks;
        private List<Comment> _comments;
        //public ToDoTaak _toDoTask1;
        private string _selectedItemGuid;
        public ToDoTaak selectedItem1;

        

        private void Window_loaded(object sender, RoutedEventArgs e)
        {
            // MessageBox.Show("Window_loaded");
            _toDoTasks = DatabaseOperations.HaalTakenOp();
            dgTakenOverzicht.ItemsSource = _toDoTasks;
        }

        private void btnZoeken_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Zoeken_Click");
        }


        private void dgTakenOverzicht_SelectonChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedItem1 = (ToDoTaak)dgTakenOverzicht.SelectedItem;

            if (selectedItem1 != null)
            {
                
                _selectedItemGuid = selectedItem1.ToDoTaskID;
                _comments = DatabaseOperations.HaalCommentsOp(_selectedItemGuid);
                dgCommentsToDo.ItemsSource = _comments;

                txtToDoID.Text = selectedItem1.ToDoTaskID;
                txtToDoTitle.Text = selectedItem1.Title;
                txtToDoBeschrijving.Text = selectedItem1.Description;
                txtToDoStatus.Text = selectedItem1.Status;
                txtToDoDatumAangemaakt.Text = selectedItem1.ToDoCreationDate.ToString();
                txtToDoDatumStarted.Text = selectedItem1.ToDoStartDate.ToString();
                txtToDoHoeLang.Text = "1 minute ago";

            }
            
            
        }

        private void btnExtraTaak_Click(object sender, RoutedEventArgs e)
        {
             MessageBox.Show("ExtraTaak_Click");

            ToDoTaak todotaak1 = new ToDoTaak(txtNewTitle.Text, txtNewBeschrijving.Text);
            txtNewTitle.Text = "titel";
            txtNewBeschrijving.Text = "beschrijving";
            DatabaseOperations.VoegToDoTaakToe(todotaak1);
            _toDoTasks = DatabaseOperations.HaalTakenOp();
            dgTakenOverzicht.ItemsSource = _toDoTasks;
            dgTakenOverzicht.Items.Refresh();
;        }

        private void btnZetSelectedTaakActief_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("ZetSelectedTaakActief_Click");
            selectedItem1.Status = "In-Progress";
            DatabaseOperations.UpdateToDoTaakToe(selectedItem1);
        }

        private void btnZetSelectedTaakPostponed_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("ZetSelectedTaakPostponed_Click");
            selectedItem1.Status = "In-Progress";
            DatabaseOperations.UpdateToDoTaakToe(selectedItem1);
        }

        private void btnZetSelectedTaakDone_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("ZetSelectedTaakDone_Click");
            selectedItem1.Status = "In-Progress";
            DatabaseOperations.UpdateToDoTaakToe(selectedItem1);
        }

        private void btnVoegCommentToe_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("VoegCommentToe_Clic");
        }

        private void btnVerwijderen_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Verwijderen_Click");

            //DatabaseOperations.UpdateToDoTaakToe(selectedItem1);
            DatabaseOperations.VewijderToDoTaakToe(selectedItem1);
            _toDoTasks = DatabaseOperations.HaalTakenOp();
            dgTakenOverzicht.ItemsSource = _toDoTasks;
            dgTakenOverzicht.Items.Refresh();

            // hier ook nog detailed window kuisen en comments kuisen
        }
    }
}
