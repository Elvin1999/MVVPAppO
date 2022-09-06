using MVVPApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVPApp.Repo
{
    public class FakeRepo
    {
        public List<Printer> GetAll()
        {
            return new List<Printer>
            {
                new Printer
                {
                    Color="Red",
                    Model="R100",
                    Vendor="Canon"
                },
                new Printer
                {
                    Color="Blue",
                    Model="LLL00",
                    Vendor="HP"
                },
                new Printer
                {
                    Color="IndianRed",
                    Model="C202",
                    Vendor="Varta"
                },
            };
        }
    }
}
