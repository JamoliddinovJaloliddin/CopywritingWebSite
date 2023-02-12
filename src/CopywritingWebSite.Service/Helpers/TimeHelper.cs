using CopywritingWebSite.Domain.Constans;

namespace CopywritingWebSite.Service.Helpers
{
    public class TimeHelper
    {
        public static DateTime GetCurrentServerTime()
        {
            return DateTime.UtcNow.AddHours(TimeConstans.UTC);
        }
    }
}
