using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindingSample_MvvmLight
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {

            ShowCommand = new RelayCommand<string>(Show);
        }

        public RelayCommand<string> ShowCommand { get; set; }//申明命令

        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                RaisePropertyChanged();//属性监控事件
            }
        }


        private string title;

        public string Title
        {
            get { return title; }
            set
            {
                title = value;
                RaisePropertyChanged();
            }
        }



        private void Show(string content)
        {
            Name = "点击了按钮";
            Title = "我是标题";
            System.Windows.MessageBox.Show(content);
        }

    }
}
