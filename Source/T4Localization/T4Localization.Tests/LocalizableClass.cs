using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T4Localization.Attributes;

namespace T4Localization.Tests
{
    [Localizable]
    public class LocalizableClass
    {
        public string Name { get; set; }

        public string Address { get; set; }

        [Localizable(MessageId = "Number")]
        public int Id { get; set; }

        [Localizable(Ignore = true)]
        public string Ignore { get; set; }
    }
}
