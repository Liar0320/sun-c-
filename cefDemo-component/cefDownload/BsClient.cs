using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xilium.CefGlue;

namespace CefDemo.bs
{
    public class BsClient:CefClient
    {
        public event EventHandler OnCreated;
        private readonly CefLifeSpanHandler lifeSpanHandler;
        private readonly CefDownloadHandler downloadHandler;        
        public BsClient()
        {
            lifeSpanHandler = new BsLifeSpanHandler(this);
            downloadHandler = new BsDownloadHandler();
        }
        protected override CefLifeSpanHandler GetLifeSpanHandler()
        {
            return lifeSpanHandler;
        }
        protected override CefDownloadHandler GetDownloadHandler()
        {
            return downloadHandler;
        }
        public void Created(CefBrowser bs)
        {
            if (OnCreated != null)
            {
                OnCreated(bs, EventArgs.Empty);
            }
        }
    }
}
