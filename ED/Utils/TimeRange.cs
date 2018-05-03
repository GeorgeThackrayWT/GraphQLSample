using System;

namespace Utils
{
    public class TimeRange
    {
        private DateTime _minDate = DateTime.MinValue;
        private DateTime _maxDate = DateTime.MaxValue;

        public TimeRange()
        {
        }

        public TimeRange(DateTime date, TimeRangeType type)
        {
            switch (type)
            {
                case TimeRangeType.Day:
                    this._minDate = new DateTime(date.Year, date.Month, date.Day);
                    this._maxDate = this.MinDate.AddDays(1).AddSeconds(-1);
                    break;

                case TimeRangeType.Week:
                    int daysOffset = (date.DayOfWeek == DayOfWeek.Sunday) ? -6
                        : DayOfWeek.Monday - date.DayOfWeek;
                    this._minDate = date.AddDays(daysOffset);
                    this._maxDate = this._minDate.AddDays(7).AddSeconds(-1);
                    break;

                case TimeRangeType.Month:
                    this._minDate = new DateTime(date.Year, date.Month, 1);
                    this._maxDate = this._minDate.AddMonths(1).AddSeconds(-1);
                    break;

                case TimeRangeType.Year:
                    this._minDate = new DateTime(date.Year, 1, 1);
                    this._maxDate = this._minDate.AddYears(1).AddSeconds(-1);
                    break;

                case TimeRangeType.FiveYears:
                    this._minDate = new DateTime(date.Year, 1, 1);
                    this._maxDate = this._minDate.AddYears(5).AddSeconds(-1);
                    break;

                case TimeRangeType.TenYears:
                    this._minDate = new DateTime(date.Year, 1, 1);
                    this._maxDate = this._minDate.AddYears(10).AddSeconds(-1);
                    break;

                case TimeRangeType.Historic:
                    this._minDate = new DateTime(1753, 1, 1);

                    this._maxDate = new DateTime(date.Year, 1, 1).AddSeconds(-1);
                    break;


            }
        }

        public TimeRange(DateTime minDate, DateTime maxDate)
        {
            this._minDate = minDate <= maxDate ? minDate : maxDate;
            this._maxDate = maxDate > minDate ? maxDate : minDate;
        }

        public DateTime MinDate
        {
            get
            {
                return this._minDate;
            }

            set
            {
                if (value <= this._maxDate)
                {
                    this._minDate = value;
                }
                else
                {
                    this._minDate = this._maxDate;
                    this._maxDate = value;
                }
            }
        }

        public DateTime MaxDate
        {
            get
            {
                return this._maxDate;
            }

            set
            {
                if (value > this._minDate)
                {
                    this._maxDate = value;
                }
                else
                {
                    this._maxDate = this._minDate;
                    this._minDate = value;
                }
            }
        }

        public bool IsInRange(DateTime value)
        {
            return value >= this.MinDate && value <= this.MaxDate;
        }
    }
}