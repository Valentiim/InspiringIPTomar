using System;
using System.Net;
using System.Threading.Tasks;
using InspiringIPTomar;

namespace Microsoft
{
    internal class web
    {
        private NetworkCredential credentials;

        public web(NetworkCredential credentials)
        {
            this.credentials = credentials;
        }

        internal static object GetInstance(NetworkCredential credentials)
        {
            throw new NotImplementedException();
        }

        internal Task DeliverAsync(SendGridMessage myMessage)
        {
            throw new NotImplementedException();
        }
    }
}