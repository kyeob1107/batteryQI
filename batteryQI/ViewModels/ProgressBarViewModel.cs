using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using Mysqlx.Crud;

namespace batteryQI.ViewModels
{
    internal class ProgressBarViewModel : ObservableObject
    {
        //private int _totalItems;
        //private int _completedItems;
        //private int _progressPercentage;

        //private readonly InspectViewModel  _inspectionService;
        //public ICommand InspectCommand { get; }

        //public int TotalItems
        //{
        //    get => _totalItems;
        //    set
        //    {
        //        SetProperty(ref _totalItems, value);
        //        UpdateProgress();
        //    }
        //}

        //public int CompletedItems
        //{
        //    get => _completedItems;
        //    set
        //    {
        //        SetProperty(ref _completedItems, value);
        //        UpdateProgress();
        //    }
        //}

        //public int ProgressPercentage
        //{
        //    get => _progressPercentage;
        //    set => SetProperty(ref _progressPercentage, value);
        //}

        //private void UpdateProgress()
        //{
        //    ProgressPercentage = TotalItems > 0 ? (int)((double)CompletedItems / TotalItems * 100) : 0;
        //}

        //public ProgressBarViewModel()
        //{
        //    // InspectionService 인스턴스 생성 (또는 DI로 주입 가능)
        //    _inspectionService = new InspectViewModel();

        //    // Command 초기화
        //    InspectCommand = new RelayCommand(Inspect);

        //    this.TotalItems = 10;
        //}

        //private void Inspect()
        //{
        //    _inspectionService.ImageInspectionButton_Click();
        //    CompletedItems++;
        //}
    }
}
