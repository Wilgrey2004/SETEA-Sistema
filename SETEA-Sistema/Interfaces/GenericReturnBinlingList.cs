using System;
using System.ComponentModel;

namespace SETEA_Sistema.Interfaces
{
        public abstract class GenericReturnBinlingList<T>
        {
                public abstract BindingList<T> GetBindingList();
        }
}
