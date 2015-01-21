using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using poc.Services;
using poc.ViewModels;

namespace poc.Controllers.Api
{
    public class DataController : ApiController
    {
        private readonly IDataService _dataService;

        public DataController()
        {
            _dataService = new DataService();
        }

        public HttpResponseMessage Get()
        {
            return Request.CreateResponse(HttpStatusCode.OK,
                GetListItemViewModelList());
        }

        private IEnumerable<ListItemViewModel> GetListItemViewModelList()
        {
            return _dataService.GetList();
        }
    }
}
