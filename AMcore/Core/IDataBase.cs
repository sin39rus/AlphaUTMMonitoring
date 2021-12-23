using AMcore.Models;

namespace AMcore.Core
{
    public interface IDataBase
    {
        public List<UtmParam> GetUtmParams();
        public void AddUtmParam(UtmParam utmParam);
    }
}
