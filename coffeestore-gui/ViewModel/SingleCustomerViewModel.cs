using coffeestore_gui.Model;

namespace coffeestore_gui.ViewModel
{
    public class SingleCustomerViewModel : ViewModelBase
    {
        private readonly Customer _model;

        public SingleCustomerViewModel(Customer model)
        {
            _model = model;
        }

        public int Id => _model.Id;
        public string? FirstName
        {
            get => _model.FirstName;
            set
            {
                _model.FirstName = value;
                RaisePropertyChanged();
            }
        }

        public string? LastName
        {
            get => _model.LastName;
            set
            {
                _model.FirstName = value;
                RaisePropertyChanged();
            }
        }

        public bool IsRegular
        {
            get => _model.IsRegular;
            set
            {
                _model.IsRegular = value;
                RaisePropertyChanged();
            }
        }

    }
}
