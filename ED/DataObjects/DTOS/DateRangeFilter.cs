using System;
using Utils;

namespace DataObjects.DTOS
{
    public class DateRangeFilter
    {
        private DateOption _dateRange;

        private DateTime _dateTimeFrom;

        private DateTime _dateTimeTo;

        public DateOption DateRange
        {
            get { return _dateRange; }

            set
            {
                _dateRange = value;
                this.calcualate();
            }
        }

        public DateTime From => _dateTimeFrom;
        public DateTime To => _dateTimeTo;

        private void calcualate()
        {
            DateTime today = DateTime.Today;

            switch (DateRange)
            {
                case DateOption.All:
                    _dateTimeFrom = new DateTime(2000,1,1);
                    _dateTimeTo = new DateTime(2050,1,1);
                    break;

                case DateOption.Month:
                    var firstDay = new DateTime(today.Year, today.Month, 1);
                    _dateTimeFrom = firstDay;
                    _dateTimeTo = firstDay.AddMonths(1).AddDays(-1);
                    break;

                case DateOption.Today:
                    _dateTimeFrom = new DateTime(today.Year, today.Month, today.Day,0,0,0 );
                    _dateTimeTo = new DateTime(today.Year, today.Month, today.Day, 23, 59, 0);
                    break;

                case DateOption.Week:
                    _dateTimeFrom = DateTime.Now.StartOfWeek(DayOfWeek.Monday);
                    _dateTimeTo = DateTime.Now.StartOfWeek(DayOfWeek.Sunday);
                    break;

                case DateOption.Year:
                    _dateTimeFrom = new DateTime(today.Year, 1, 1);
                    _dateTimeTo = new DateTime(today.Year, 12, 31);
                    break;
            }
        }



    }
}
