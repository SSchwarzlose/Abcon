using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Abcon.Models
{
    class Department : INotifyPropertyChanged
    {
        #region Fields
        private ulong _id;
        private string _name;
        #endregion
        #region Properties
        public ulong ID { get { return this._id; } private set { this._id = value; } }
        public string Name { get { return this._name; } set { this._name = value; } }
        #endregion
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
