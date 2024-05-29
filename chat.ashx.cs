using ServerSendEvent.Methods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace ServerSendEvent
{
    /// <summary>
    /// chat 的摘要描述
    /// </summary>
    public class chat : HttpTaskAsyncHandler
    {
        HttpRequest req;
        HttpResponse res;

        //public async void ProcessRequest(HttpContext context)
        //{
        //    req = context.Request;
        //    res = context.Response;
        //    if (req.QueryString.Count == 0)
        //    {
        //        res.ContentType = "text/html";
        //        res.WriteFile(context.Server.MapPath("Pages/chat.html"));
        //        return;
        //    }

        //    res.Headers.Remove("Server");
        //    res.Headers.Remove("X-AspNet-Version");
        //    res.ContentType = "text/event-stream";
        //    res.Headers.Add("Cache-Control", "no-cache");
        //    res.Headers.Add("Connection", "keep-alive");

        //    // Allow Cross-Origin Resource Sharing (CORS)
        //    res.Headers.Add("Access-Control-Allow-Origin", "*");
        //    res.Headers.Add("Access-Control-Allow-Headers", "Content-Type");

        //    //string message = "Hello, I am streaming this text letter by letter.";
        //    //foreach (char c in message)
        //    //{
        //    //    res.Write($"data: {c}\n\n");
        //    //    res.Flush();
        //    //    System.Threading.Thread.Sleep(50);
        //    //}
        //    //res.Write("data: close\n\n");
        //    string[] aChatString = new string[] { "Hello", "World", "How", "Are", "You" };
        //    await ProcessChatStream(aChatString);
        //    res.End();
        //}


        public async Task ProcessChatStream(IEnumerable<string> chatStream)
        {
            foreach (string message in chatStream)
            {
                foreach (var c in message)
                {
                    res.Write($"data: {c}\n\n");
                    res.Flush();
                    await Task.Delay(50);
                }
                var rand = new Random();
                await Task.Delay(rand.Next(30, 100));
            }

            res.Write("data: close\n\n");
        }

        public override async Task ProcessRequestAsync(HttpContext context)
        {
            req = context.Request;
            res = context.Response;
            if (req.QueryString.Count == 0)
            {
                res.ContentType = "text/html";
                res.WriteFile(context.Server.MapPath("Pages/chat.html"));
                return;
            }

            res.Headers.Remove("Server");
            //res.Headers.Remove("X-AspNet-Version");
            res.ContentType = "text/event-stream";
            res.Headers.Add("Cache-Control", "no-cache");
            res.Headers.Add("Connection", "keep-alive");

            // Allow Cross-Origin Resource Sharing (CORS)
            res.Headers.Add("Access-Control-Allow-Origin", "*");
            res.Headers.Add("Access-Control-Allow-Headers", "Content-Type");

            //string message = "Hello, I am streaming this text letter by letter.";
            //foreach (char c in message)
            //{
            //    res.Write($"data: {c}\n\n");
            //    res.Flush();
            //    System.Threading.Thread.Sleep(50);
            //}
            //res.Write("data: close\n\n");
            var aChatString = Chat.GetChatStrings();
            await ProcessChatStream(aChatString);
            res.End();
        }
    }
}