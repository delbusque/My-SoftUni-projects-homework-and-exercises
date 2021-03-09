using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony
{
    public interface ISmartphonable
    {
        public void Calling(string number);

        public void Browsing(string site);
    }
}
