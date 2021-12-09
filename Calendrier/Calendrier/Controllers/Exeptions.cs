using System;
namespace Calendrier
{
    public class CalendarException : Exception
    {
    }

    public class GameAlreadyUsedException : CalendarException
    {
    }
    public class EventAlreadyUsedException : CalendarException
    {
    }
} 