using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Model.Base
{
    public  class BaseMovie
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Url { get; set; }

        public string Created { get; set; }
    }
}
