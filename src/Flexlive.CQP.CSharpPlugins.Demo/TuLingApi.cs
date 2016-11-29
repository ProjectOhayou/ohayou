using System.Net;
using System.Text;

namespace Flexlive.CQP.CSharpPlugins.Demo
{
    public static class TuLingApi
    {
        public static string PostTuLingApi(string message)
        {
            string postData = "key=3e65d35b9c37436b9816c6191fa53f23&info="+ message;

            byte[] bytes = Encoding.UTF8.GetBytes(postData);

            WebClient client = new WebClient();
            client.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
            client.Headers.Add("ContentLength", postData.Length.ToString());
            byte[] responseData = client.UploadData("http://www.tuling123.com/openapi/api", "POST", bytes);
            var result = Encoding.UTF8.GetString(responseData);
            return result;
        }
    }
}