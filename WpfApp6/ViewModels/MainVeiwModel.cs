using System.Collections.Generic;
using System.Collections.ObjectModel;
using WpfApp6.Models;
using WpfApp6.Repositories.Abstract;
using WpfApp6.Repositories.Concrets;

namespace WpfApp6.ViewModels
{
    public class MainVeiwModel
    {
        private readonly ICarRepository? _carRepository;
        public ObservableCollection<Car>? Car { get; set; }


        public MainVeiwModel()
        {
            _carRepository = new FakeCarRepository();
            Car = new(_carRepository.GetList() ?? new List<Car>());
        }

    }
}
