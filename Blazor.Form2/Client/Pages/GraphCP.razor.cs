using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.Form2.Client.Pages
{
    public partial class GraphCP
    {
        //porcentaje

        public double porcentaje { get; set; }
        public double porS { get; set; }

        public double porCS { get; set; }
        public double porSyCS50 { get; set; }
        public double porSyCS { get; set; }


        public int _numcuestion { get; set; } = 0;

        public int _nunca { get; set; } = 0;

        public int _cn { get; set; }

        public int _av { get; set; }

        public int _cs { get; set; }

        public int _s { get; set; }

        List<SalesInfo> Sales = null;
        [Parameter]
        public string total { get; set; }
        [Parameter]
        public string nunca { get; set; }

        [Parameter]
        public string cn { get; set; }

        [Parameter]
        public string av { get; set; }

        [Parameter]
        public string cs { get; set; }

        [Parameter]
        public string s { get; set; }



        [Parameter]
        public string numcuestion { get; set; }
        protected async override Task OnInitializedAsync()
        {

            _nunca = Int32.Parse(nunca);
            _cn = Int32.Parse(cn);
            _av = Int32.Parse(av);
            _cs = Int32.Parse(cs);
            _s = Int32.Parse(s);
            _numcuestion = Int32.Parse(numcuestion);
            Llenado();


            porCS = GetPorcentaje(_numcuestion, _cs);

            porS = GetPorcentaje(_numcuestion, _s);



        }


        public class SalesInfo
        {
            public string Month { get; set; }
            public double SalesValue { get; set; }
        }
        public void Llenado()
        {


            Sales = new List<SalesInfo>
{
    new SalesInfo { Month = "Nunca", SalesValue = _nunca},
    new SalesInfo { Month = "Casi Nunca", SalesValue = _cn },
    new SalesInfo { Month = "A veces", SalesValue = _av },
    new SalesInfo { Month = "Casi Siempre", SalesValue = _cs },
    new SalesInfo { Month = "Siempre", SalesValue = _s },

};
        }



        public double GetPorcentaje(int value, int numCues)
        {
            double result = ((numCues * 100) / value);

            return result;
        }
    }

}
