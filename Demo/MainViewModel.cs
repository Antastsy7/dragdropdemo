using GongSolutions.Wpf.DragDrop;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class CustomData
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
    internal class MainViewModel : IDropTarget
    {
        public ObservableCollection<CustomData> CustomDatas { get; set; }

        public MainViewModel()
        {
            CustomDatas = new ObservableCollection<CustomData>();
            CustomDatas.Add(new CustomData() { Name = "Name1", Description = "Description1" });
            CustomDatas.Add(new CustomData() { Name = "Name2", Description = "Description2" });
            CustomDatas.Add(new CustomData() { Name = "Name3", Description = "Description3" });
            CustomDatas.Add(new CustomData() { Name = "Name4", Description = "Description4" });
            CustomDatas.Add(new CustomData() { Name = "Name5", Description = "Description5" });
        }

        public void DragOver(IDropInfo dropInfo)
        {
            dropInfo.DropTargetAdorner = DropTargetAdorners.Highlight;
        }

        public void Drop(IDropInfo dropInfo)
        {
            Console.WriteLine(dropInfo);
        }
    }
}
