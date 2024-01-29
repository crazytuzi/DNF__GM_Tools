using AY.DNF.GMTool.Db.Models;
using AY.DNF.GMTool.Db.Services;
using HandyControl.Controls;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace AY.DNF.GMTool.ActivityEvent.ViewModels
{
    class ActivityEventPageViewModel : BindableBase
    {
        #region 属性

        private ObservableCollection<ActivityEventModel> _activities = new ObservableCollection<ActivityEventModel>();

        public ObservableCollection<ActivityEventModel> Activities
        {
            get { return _activities; }
            set { SetProperty(ref _activities, value); }
        }

        private ObservableCollection<EventInfoModel> _activityEvents = new ObservableCollection<EventInfoModel>();

        public ObservableCollection<EventInfoModel> ActivityEvents
        {
            get { return _activityEvents; }
            set { SetProperty(ref _activityEvents, value); }
        }

        private int _param1 = 0;

        public int Param1
        {
            get { return _param1; }
            set { SetProperty(ref _param1, value); }
        }

        private int _param2 = 0;

        public int Param2
        {
            get { return _param2; }
            set { SetProperty(ref _param2, value); }
        }

        private bool _delEnabled = false;

        public bool DelEnabled
        {
            get { return _delEnabled; }
            set { SetProperty(ref _delEnabled, value); }
        }

        private ActivityEventModel? _selectedCurEvent;

        public ActivityEventModel? SelectedCurEvent
        {
            get { return _selectedCurEvent; }
            set
            {
                SetProperty(ref _selectedCurEvent, value);

                DelEnabled = value != null;
            }
        }

        private bool _addEnabled;

        public bool AddEnabled
        {
            get { return _addEnabled; }
            set { SetProperty(ref _addEnabled, value); }
        }

        private EventInfoModel? _selectedEvent;

        public EventInfoModel? SelectedEvent
        {
            get { return _selectedEvent; }
            set
            {
                SetProperty(ref _selectedEvent, value);

                AddEnabled = value != null;
                if (value == null)
                {
                    Msg = string.Empty;
                    return;
                }

                var plain = value!.EventExplain;

                var arr = plain.Split("|", StringSplitOptions.RemoveEmptyEntries);
                if (arr.Length >= 2 && arr[1] == "百分比")
                    Msg = "参数1请填写100的倍数";
                else
                    Msg = string.Empty;
            }
        }

        private string _msg;

        public string Msg
        {
            get { return _msg; }
            set { SetProperty(ref _msg, value); }
        }

        #endregion

        #region 命令

        ICommand _refreshCurrentActivitiesCommand;

        public ICommand RefreshCurrentActivitiesCommand => _refreshCurrentActivitiesCommand ??= new DelegateCommand(DoRefreshCurrentActivitiesCommand);

        ICommand _addEventCommand;

        public ICommand AddEventCommand => _addEventCommand ??= new DelegateCommand(DoAddEventCommand);

        ICommand _deleteCurrentActivityCommand;

        public ICommand DeleteCurrentActivityCommand => _deleteCurrentActivityCommand ??= new DelegateCommand(DoDeleteCurrentActivityCommand);

        #endregion

        public ActivityEventPageViewModel()
        {
            DoRefreshCurrentActivitiesCommand();

            LoadEvents();
        }

        async void LoadEvents()
        {
            ActivityEvents.Clear();
            var list = await new ActivityService().QueryEventInfos();
            ActivityEvents.AddRange(list);
        }

        /// <summary>
        /// 当前活动
        /// </summary>
        async void DoRefreshCurrentActivitiesCommand()
        {
            Activities.Clear();

            var list = await new ActivityService().QueryAcitivities();

            Activities.AddRange(list);
        }

        async void DoAddEventCommand()
        {
            if (SelectedEvent == null)
            {
                Growl.Warning("请选择活动");
                return;
            }

            var b = await new ActivityService().AddEvent(new ActivityEventModel
            {
                EventType = SelectedEvent.EventId,
                Parameter1 = Param1,
                Parameter2 = Param2
            });

            SelectedEvent = null;
            Msg = $"添加活动{(b ? "成功" : "失败")}";

            DoRefreshCurrentActivitiesCommand();
        }

        async void DoDeleteCurrentActivityCommand()
        {
            if (SelectedCurEvent == null)
            {
                Growl.Warning("请在当前活动列表中选择要删除的活动");
                return;
            }

            var logId = SelectedCurEvent.LogId;
            var b = await new ActivityService().DeleteEvent(logId);

            Msg = $"删除活动{(b ? "成功" : "失败")}";

            SelectedCurEvent = null;
            DelEnabled = false;

            DoRefreshCurrentActivitiesCommand();
        }
    }
}
