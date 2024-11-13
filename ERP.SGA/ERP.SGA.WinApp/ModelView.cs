using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.SGA.WinApp
{
    public class ModelView
    {
        public static ObservableCollection<T> ToObservableCollection<T>(IList<T> listInput)
        {
            if (listInput == null)
            {
                ObservableCollection<T> myCollection = new ObservableCollection<T>(listInput as List<T>);
                return myCollection;
            }
            else return new ObservableCollection<T>();
        }
    }
}
