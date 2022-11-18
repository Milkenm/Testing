using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace HttpListenerTest
{
	public delegate byte[] ProcessResponseDelegate(string data);

	public class HttpServer
	{
		private readonly HttpListener listener;
		private readonly ProcessResponseDelegate handler;

		public HttpServer(HttpListener listener, string url, ProcessResponseDelegate handler)
		{
			this.listener = listener;
			this.handler = handler;
			listener.Prefixes.Add(url);
		}
		public HttpServer(string url, ProcessResponseDelegate handler) : this(new HttpListener(), url, handler) { }
		public HttpServer(ProcessResponseDelegate handler) : this("http://127.0.0.1/", handler) { }

		public void Start()
		{
			if (!listener.IsListening)
			{
				listener.Start();
			}

			listener.GetContextAsync().ContinueWith(this.ProcessRequestHandler);
		}

		public void Stop()
		{
			if (listener.IsListening)
			{
				listener.Stop();
			}
		}

		private void ProcessRequestHandler(Task<HttpListenerContext> result)
		{
			HttpListenerContext context = result.Result;

			if (!listener.IsListening)
			{
				return;
			}

			// START LISTENING AGAIN \\
			listener.GetContextAsync().ContinueWith(this.ProcessRequestHandler);

			// READ RESPONSE \\
			string request = new StreamReader(context.Request.InputStream).ReadToEnd();

			// SEND RESPONSE \\
			byte[] responseBytes = handler.Invoke(request);
			context.Response.ContentLength64 = responseBytes.Length;

			Stream output = context.Response.OutputStream;
			output.WriteAsync(responseBytes, 0, responseBytes.Length);
			output.Close();
		}
	}
}
