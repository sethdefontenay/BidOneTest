using System;
using System.IO;
using Newtonsoft.Json;
using TestBidone.Models;

namespace TestBidone.Data
{
    public class LocalJsonStore: IDataClient
    {
        public IModel Save(Guid Id, IModel model)
        {
            var modelString = SerializeModel(model);
            File.WriteAllText($"data/{Id.ToString()}.json", modelString);
            return model;
        }

        public string SerializeModel(IModel model)
        {
            return JsonConvert.SerializeObject(model);
        }
    }
}
