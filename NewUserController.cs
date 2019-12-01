using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TestBidone.Data;
using TestBidone.Models;

namespace TestBidone
{
    public class NewUserController : Controller
    {
        private IDataClient _dataClient;
        private ILogger _logger;
        public NewUserController(IDataClient dataClient, ILogger logger)
        {
            _dataClient = dataClient;
            _logger = logger;
        }

        // GET: NewUser
        public ActionResult Index()
        {
            return View();
        }

        // POST: NewUser/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(UserModel model)
        {
            try
            {
                model.Id = Guid.NewGuid();
                _logger.Info($"Saving item: {model.Id}");
                _dataClient.Save(model.Id, model);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}