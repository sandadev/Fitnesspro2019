using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitnesspro.Infrastructure.Models
{
   public class ServiceGroupList<K,T>
    {
        public K ServiceGroupName;
        public IEnumerable<T> SeriveList;
    }
}
