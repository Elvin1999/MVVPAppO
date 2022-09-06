using MVVPApp.Command;
using MVVPApp.Models;
using MVVPApp.Repo;
using MVVPApp.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVPApp.ViewModels
{
    public class AppViewModel:BaseViewModel
    {
        public FakeRepo PrinterRepository { get; set; }
        public ObservableCollection<Printer> Printers { get; set; }
        private Printer printer;

        public Printer Printer
        {
            get { return printer; }
            set { printer = value; OnPropertyChanged(); }
        }


        public RelayCommand SelectCommand { get; set; }
        public RelayCommand EditCommand { get; set; }
        public AppViewModel()
        {
            PrinterRepository=new FakeRepo();
            Printers = new ObservableCollection<Printer>(PrinterRepository.GetAll());
            Printer=new Printer();


            SelectCommand = new RelayCommand(e =>
              {
                  Printer = e as Printer;
              });

            EditCommand = new RelayCommand(e =>
            {
                var view = new EditView();
                var editViewModel = new EditViewModel();
                editViewModel.EditPrinter = Printer;
                editViewModel.EditView = view;

                view.DataContext = editViewModel;
                view.ShowDialog();
            }, p =>
            {
                return Printer?.Vendor?.Length > 2;
            });

        }
    }
}
