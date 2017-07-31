using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Abcon.Models
{
    class Employee : INotifyPropertyChanged
    {
        #region Fields
        private ulong _id;
        private string _name;
        private string _firstName;
        private ulong _departmentId;
        private ulong _marketId;
        private int _vacationClaim;

        #endregion

        #region properties
        public ulong ID { get { return this._id; } private set { this._id = value; } }
        public string Name { get { return this._name; } set { this._name = value; } }
        public string FirstName { get { return this._firstName; } set { this._firstName = value; } }
        public ulong Market { get { return this._marketId; } set { this._marketId = value; } }
        public ulong Department { get { return this._departmentId; } set { this._departmentId = value; } }
        public int VacationClaim { get { return this._vacationClaim; } set { this._vacationClaim = value; } }
        #endregion

        #region Cunstructor
        public Employee(ulong id, string name, string firstName, ulong marketId, ulong departmentId, int vacationClaim)
        {
            ID = id;
            Name = name;
            FirstName = firstName;
            Market = marketId;
            Department = departmentId;
            VacationClaim = vacationClaim;
        }
        #endregion

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public bool Set<T>(ref T storage, T value, [CallerMemberName]string propertyName = null)
        {
            if(Equals(storage, value))
            {
                return false;
            }
            storage = value;
            RaisePropertyChanged(propertyName);
            return true;
        }
    }
}
