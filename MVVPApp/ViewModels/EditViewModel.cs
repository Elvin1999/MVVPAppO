using MVVPApp.Command;
using MVVPApp.Models;
using MVVPApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MVVPApp.ViewModels
{
    public class EditViewModel:BaseViewModel
    {
        public EditView EditView { get; set; }
        public RelayCommand SaveCommand { get; set; }
        private Printer editPrinter;

        public Printer EditPrinter
        {
            get { return editPrinter; }
            set { editPrinter = value;OnPropertyChanged(); }
        }

        public EditViewModel()
        {
            SaveCommand = new RelayCommand((e) =>
              {
                  EditView.Close();
                  MessageBox.Show("Save data successfully");
              });
        }

    }
}
