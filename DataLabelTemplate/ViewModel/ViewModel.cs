using System.Collections.ObjectModel;

namespace DataLabelTemplate
{
    public class ChartViewModel
    {
        public ObservableCollection<Model> Data { get; set; }
        public ChartViewModel()
        {
            Data = new ObservableCollection<Model>();
            Data.Add(new Model() { Department = "Total", Value = 18000 });
            Data.Add(new Model() { Department = "Production", Value = -2000 });
            Data.Add(new Model() { Department = "Sales", Value = -5000 });
            Data.Add(new Model() { Department = "Investors contribution", Value = 3000 });
            Data.Add(new Model() { Department = "Logistics", Value = -1000 });
            Data.Add(new Model() { Department = "Shares profit", Value = 4000 });
            Data.Add(new Model() { Department = "Marketing", Value = -3000 });
            Data.Add(new Model() { Department = "Transport", Value = -1500 });
            Data.Add(new Model() { Department = "Balance", Value = 0, IsSummary = true });

        }
    }
}
