using Internet_1.Models;

namespace Internet_1.Repositories
{
    public class TosubmitRepository: GenericRepository<Tosubmit>
    {

        public TosubmitRepository(AppDbContext context) : base(context)
        {

        }
    }
}
