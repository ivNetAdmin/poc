
using System.Collections.Generic;
using System.Xml;
using poc.ViewModels;

namespace poc.Services
{
    public interface IDataService
    {
        IEnumerable<ListItemViewModel> GetList();
    }

    public class DataService : IDataService
    {
        public IEnumerable<ListItemViewModel> GetList()
        {
            var rtnList = new List<ListItemViewModel>();

            var dataFile = System.Web.HttpContext.Current.Server.MapPath("~/App_Data/ListData.xml");

            var xmlDoc = new XmlDocument();
            xmlDoc.Load(dataFile);

            var nodeList = xmlDoc.SelectNodes("list/item");

            foreach (XmlNode node in nodeList)
            {
                rtnList.Add(new ListItemViewModel
                {
                    Text = node["text"].InnerText,
                    Value = node["value"].InnerText
                });


            }
            return rtnList;
        }
    }
}