using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionHierarchy.Contracts
{
    public interface IAddRemove : IAdd
    {
        string Remove(string element);
    }
}
