using ControleVeiculos.Models;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows;

namespace ControleVeiculos.ViewModels
{
    internal class SideMenuViewModel : BaseViewModel
    {
        public ObservableCollection<Category> Categories { get; set; }

        public ICommand ButtonCommand { get; }

        private Frame _navigationFrame;
        public Frame NavigationFrame
        {
            get { return _navigationFrame; }
            set { _navigationFrame = value; }
        }

        public SideMenuViewModel()
        {
            ButtonCommand = new RelayCommand(OnButtonCommandExecute);

            Categories = new ObservableCollection<Category>
            {
                new Category
                {
                    Name = "Cadastro",
                    Subcategories = new List<Category>
                    {
                        new Category{Name = "Veiculos"},
                        new Category{Name = "Entidades"},
                        new Category{Name = "Check List"}
                    }
                },
                new Category
                {
                    Name = "Importações",
                    Subcategories = new List<Category>
                    {
                        new Category{Name = "Importar NFe"}
                    }
                },
                new Category
                {
                    Name = "Consultas",
                    Subcategories = new List<Category>
                    {
                        new Category{Name = "Consulta NFe"},
                        new Category{Name = "Consulta Veiculos"}
                    }
                },
                new Category
                {
                    Name = "Analises",
                    Subcategories = new List<Category>
                    {
                        new Category{Name = "Dashboard"}                    
                    }
                }
            };
        }

        private void OnButtonCommandExecute(object parameter)
        {
            string subcategoryName = parameter as string;
            if (subcategoryName != null && _navigationFrame != null)
            {
                switch (subcategoryName)
                {
                    case "Veiculos":
                        _navigationFrame.Navigate(new Uri("Views/Pages/CadastroVeiculoPage.xaml", UriKind.Relative));
                        break;
                    case "Fornecedores":
                        _navigationFrame.Navigate(new Uri("Views/SubcategoryPage2.xaml", UriKind.Relative));
                        break;
                    default:
                        MessageBox.Show($"Página para {subcategoryName} não encontrada.");
                        break;
                }
            }
        }
    }
}
