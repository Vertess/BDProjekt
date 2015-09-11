using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDProjekt
{
    class ContextInformation
    {
        private static ContextInformation _instance;
        public KsiegarniaEntities _context;

        private ContextInformation()
        {
            _instance = this;
            this._context = new KsiegarniaEntities();
        }
        public static ContextInformation Instance
        {
            get
            {
                return _instance == null ? new ContextInformation() : _instance;
            }
        }
    }
}
