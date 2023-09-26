using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;
using SimpleExampleWpfApp.Infrastructure.Commands;
using SimpleExampleWpfApp.Models;
using SimpleExampleWpfApp.Services.Interfaces;
using SimpleExampleWpfApp.Services;
using SimpleExampleWpfApp.ViewModels.Base;
// using SimpleExampleWpfApp.Views.Windows;
using SimpleExampleWpfApp.Services;
using System.Diagnostics;

namespace SimpleExampleWpfApp.ViewModels
{
    class MainWindowViewModel : ViewModel
    {
        GroupsService groupsService;

        #region Title : string - Заголовок окна

        /// <summary>Заголовок окна</summary>
        private string _Title = "SimpleExampleWpfApp--Управление студентами-2";

        /// <summary>Заголовок окна</summary>
        public string Title { get => _Title; set => Set(ref _Title, value); }

        #endregion
        public IEnumerable<Group> Groups => groupsService.GetAll();

        #region Команды
        #region Command TestCommand - Тестовая команда
        /// <summary>Тестовая команда</summary>
        private ICommand _TestCommand;

        /// <summary>Тестовая команда</summary>
        public ICommand TestCommand => _TestCommand
            ??= new LambdaCommand(OnTestCommandExecuted, CanTestCommandExecute);

        /// <summary>Проверка возможности выполнения - Тестовая команда</summary>
        private bool CanTestCommandExecute(object p) => true;

        /// <summary>Логика выполнения - Тестовая команда</summary>
        private void OnTestCommandExecuted(object p)
        {
            //var value = _UserDialog.GetStringValue("Введите строку", "123", "Значение по умолчанию");
            //_UserDialog.ShowInformation($"Введено: {value}", "123");
            Debug.WriteLine("MainWindowViewModel--OnTestCommandExecuted(object p)");
        }

        #endregion

        #region Command DeleteAllCommand - Удалить всё
        /// <summary>Тестовая команда</summary>
        private ICommand _DeleteAllCommand;

        /// <summary>Тестовая команда</summary>
        public ICommand DeleteAllCommand => _DeleteAllCommand
            ??= new LambdaCommand(OnDeleteAllCommandExecuted, CanDeleteAllCommandExecute);

        /// <summary>Проверка возможности выполнения - Тестовая команда</summary>
        private bool CanDeleteAllCommandExecute(object p) => true;

        /// <summary>Логика выполнения - Тестовая команда</summary>
        private void OnDeleteAllCommandExecuted(object p)
        {   
            groupsService.DeleteAll();
            Debug.WriteLine("MainWindowViewModel--OnDeleteAllCommandExecuted(object p)");
        }

        #endregion
        
        #endregion

        public MainWindowViewModel()
        {
            groupsService = new GroupsService();
        }
    }
}
