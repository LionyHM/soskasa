using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SosKasa.Presentation.Definition.ViewModel
{
    public class ClientViewModel
    {
        public string Name { get; set; }
        public Address Address { get; set; }
        public string CelNumber { get; set; }
        public DateTime BirthDate { get; set; }

    }
}
