using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace CollectedSamples.ViewModels
{
    public class EmployeeListViewModel : BaseViewModel
    {
        public Command AddEmployeeCommand => new Command(AddEmployee);

        public Command RemoveEmployeeCommand => new Command(RemoveEmployee);

        public Command UpdateEmployeeCommand => new Command(UpdateEmployee);

        public ObservableCollection<string> Employees { get; set; }

        public string SelectedEmployee { get; set; }

        public string EmployeeName { get; set; }

        public EmployeeListViewModel()
        {
            Title = "Employees";
            Employees = new ObservableCollection<string>
            {
                "Cierra Vega", "Alden Cantrell", "Kierra Gentry", "Pierre Cox", "Thomas Crane",
                "Miranda Shaffer", "Bradyn Kramer", "Alvaro Mcgee"
            };
        }

        public void AddEmployee()
        {
            Employees.Add(EmployeeName);
        }

        public void RemoveEmployee()
        {
            Employees.Remove(SelectedEmployee);
        }

        public void UpdateEmployee()
        {
            int newIndex = Employees.IndexOf(SelectedEmployee);
            Employees.Remove(SelectedEmployee);

            Employees.Add(EmployeeName);
            int oldIndex = Employees.IndexOf(EmployeeName);

            Employees.Move(oldIndex, newIndex);
        }
    }
}
