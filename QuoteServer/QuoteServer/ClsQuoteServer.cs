using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace QuoteServer
{
    public class ClsQuoteServer
    {
        private TcpListener listener;
        private int port;
        private string filename;
        private List<string> quotes;
        private Random random;
        private Thread listenerThread;
       
        //
        public ClsQuoteServer():this ("Quote.txt")
        {
            
        }

        public ClsQuoteServer(string filename):this(filename,7890)
        {
        }

        private ClsQuoteServer(string filename, int port)
        {
            this.filename = filename;
            this.port = port;
        }
        protected void ReadQuotes()
        {
            quotes = new List<string>();
            Stream stream = File.OpenRead(filename);
            StreamReader streamReader = new StreamReader(stream);
            string quote;
            while ((quote = streamReader.ReadLine()) != null)
            {
                quotes.Add(quote);
            }
            streamReader.Close();
            stream.Close();
            random = new Random();
        }
        protected string GetRandomQuoteOfTheDay()
        {
            int index = random.Next(0, quotes.Count);
            return quotes[index];
        }
        public void Start()
        {
            ReadQuotes();
            listenerThread = new Thread(ListenerThread);
            listenerThread.IsBackground = true;
            listenerThread.Name = "Listener";
            listenerThread.Start();
        }
        protected void ListenerThread()
        {
            try
            {
                IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
                listener = new TcpListener(ipAddress,port);
                listener.Start();
                while (true)
                {
                    Socket clientSocket = listener.AcceptSocket();
                    string message = GetRandomQuoteOfTheDay();
                    UnicodeEncoding encoder = new UnicodeEncoding();
                    byte[] buffer = encoder.GetBytes(message);
                    clientSocket.Send(buffer, buffer.Length, 0);
                    clientSocket.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);         
            }
        }
        public void Stop()
        {
            listener.Stop();
        }
        public void Suspend()
        {
            listener.Stop();
        }
        public void Resume()
        {
            listener.Stop();
        }
        public void RefreshQuotes()
        {
            ReadQuotes();
        }
    }
    
}
