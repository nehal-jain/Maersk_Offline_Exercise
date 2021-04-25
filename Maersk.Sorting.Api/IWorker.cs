using System.Collections.Generic;
using System.Threading.Tasks;

namespace Maersk.Sorting.Api
{
    public interface IWorker
    {
        public List<SortJob> ProcessSortJob(List<SortJob> job);
    }
}