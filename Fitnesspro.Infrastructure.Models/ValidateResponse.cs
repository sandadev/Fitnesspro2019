using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitnesspro.Infrastructure.Models
{
  public  class ValidateResponse
    {
        public bool IsSuccess { set; get; }
        public List<string> ValidationMessages { set; get; }
    }
}
