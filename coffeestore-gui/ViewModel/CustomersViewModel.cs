using coffeestore_gui.Data;
using coffeestore_gui.Model;
using System.Collections.ObjectModel;

namespace coffeestore_gui.ViewModel
{
    public class CustomersViewModel : ViewModelBase
    {
        private readonly ICustomerDataProvider _customerDataProvider;
        private SingleCustomerViewModel? _selectedCustomer;
        private int _navigationColumn;

        public CustomersViewModel(ICustomerDataProvider customerDataProvider)
        {
            _customerDataProvider = customerDataProvider;
        }

        public ObservableCollection<SingleCustomerViewModel> Customers { get; } = new();
        public SingleCustomerViewModel? SelectedCustomer 
        { 
            get => _selectedCustomer; 
            set
            {
                _selectedCustomer = value;
                RaisePropertyChanged();
            }
        }

        public int NavigationColumn { 
            get => _navigationColumn; 
            private set
            {
                _navigationColumn = value;
                RaisePropertyChanged();
            }
        }

        public async Task LoadAsync()
        {
            if(Customers.Any())
            {
                return;
            }
            var customers = await _customerDataProvider.GetAllAsync();
            if(customers is not null) { 
                foreach (var customer in customers)
                {
                Customers.Add(new SingleCustomerViewModel(customer));
                }
            }
        }

        internal void Add()
        {
            var customer = new Customer { FirstName = "New" , LastName = "Name"};
            var viewModel = new SingleCustomerViewModel(customer);
            Customers.Add(viewModel);
            SelectedCustomer = viewModel;
        }
        internal void MoveNavigation()
        {
            NavigationColumn = NavigationColumn == 0 ? 2 : 0;
        }

    }
}
