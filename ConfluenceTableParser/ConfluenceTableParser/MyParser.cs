using AngleSharp; // library for parsing
using System.Linq;

namespace ConfluenceTableParser
{
    public static class MyParser
    {
        // adding url link to web page
        private readonly static string url = "https://wiki.samoletgroup.ru/pages/viewpage.action?pageId=69965674";
        public static UsageMaterialStorage GetDataTable()
        {
            var config = Configuration.Default.WithDefaultLoader();
            var context = BrowsingContext.New(config);
            var docOpenTask = context.OpenAsync(url);
            var docHTML = docOpenTask.Result;

            UsageMaterialStorage materialStorage = new UsageMaterialStorage();
            if (!string.IsNullOrEmpty(docHTML.Title))
            {
                // select table from page by url and inside of it get all elements with tag <tr> (rows of table)
                // inside of <tr> filter elements wirh tags <th> (head of table)
                var tableRowData = docHTML.GetElementsByTagName("table").First().GetElementsByTagName("tr").
                    Where(elem => !elem.InnerHtml.Contains("th"));

                foreach (var item in tableRowData)
                {
                    var dataRowMaterial = item.GetElementsByTagName("td");
                    UsageMaterial usageMaterial = new UsageMaterial(dataRowMaterial[0].TextContent, dataRowMaterial[1].TextContent, dataRowMaterial[2].TextContent,
                        dataRowMaterial[3].TextContent, dataRowMaterial[4].TextContent, dataRowMaterial[5].TextContent);
                    materialStorage.AddMaterialToStorage(usageMaterial);
                }
            }
            return materialStorage;
        }
    }
}
