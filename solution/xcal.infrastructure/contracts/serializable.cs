﻿using reexjungle.xcal.infrastructure.serialization;

namespace reexjungle.xcal.infrastructure.contracts
{
    public interface ICalendarSerializable
    {
        /// <summary>
        /// Converts an object into its iCalendar representation.
        /// </summary>
        /// <param name="writer">The iCalendar writer used to serialize the object.</param>
        void WriteCalendar(CalendarWriter writer);

        /// <summary>
        /// Generates an object from its iCalendar representation.
        /// </summary>
        /// <param name="reader">The iCalendar reader used to deserialize data into the iCalendar object.</param>
        /// <returns>True if the deserialization operation was successful; otherwise false.</returns>
        void ReadCalendar(CalendarReader reader);
    }

}
