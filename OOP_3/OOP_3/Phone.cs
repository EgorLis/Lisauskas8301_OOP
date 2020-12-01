using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_3
{
    enum PhoneType
    {
        mobile = 1,
        work = 2,
        home = 3
    }
    class Phone
    {
        public PhoneType type { get; }
        public string number { get; }

        public Phone(string PhoneNumber, PhoneType phoneType)
        {
            type = phoneType;
            number = PhoneNumber;
        }

    }
}
