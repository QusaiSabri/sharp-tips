using NodaTime;

namespace SharpTips.Application.Services
{
    public class DateTimeService
    {
        public DateTime ConvertLocalToUtc(DateTime localDateTime, string timeZoneId)
        {
            var timeZone = DateTimeZoneProviders.Tzdb[timeZoneId];
            var localDateTimeInZone = LocalDateTime.FromDateTime(localDateTime);
            var zonedDbDateTime = localDateTimeInZone.InZoneLeniently(timeZone);
            return zonedDbDateTime.ToDateTimeUtc();
        }

    }
}
