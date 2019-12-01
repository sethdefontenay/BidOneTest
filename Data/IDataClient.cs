using System;
using System.Collections.Generic;
using TestBidone.Models;

namespace TestBidone.Data
{
    public interface IDataClient
    {
        IModel Save(Guid Id, IModel model);
    }
}
