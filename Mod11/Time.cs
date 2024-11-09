namespace Time
{
using System;

/// <summary>
///    A Time comprises a number of hours and a number of minutes
///    The following operators are defined:
///    +(Time, Time)   adds two Times together
///    +(Time, int)    adds a number of minutes to a Time
///    -(Time, Time)   subtracts one time from the other (the first must be bigger)
///    -(Time, int)    subtracts a number of minutes from a Time
///    ++              advances the Time by one minute
///    --              subtracts a minute from the Time
///    ToString(Time)        returns a string representation of the Time
///    Equals(Time, Time)    compares two Times, returns true if they are the same, false otherwise
///    >, <, >=, <=, ==, !=  perform comparisons on Times
///    int, float, Time      conversion operators
/// </summary>
public struct Time
{
	// compiler generated no-arg struct constructor 
	// sets hours and minutes to zero

	public Time(int minutes) : this(0, minutes)
	{
	}

	public Time(int hours, int minutes)
	{
		this.hours = hours;
		this.minutes = minutes;
		this.Normalize();
	}

	// arithmetic
	
	public static Time operator+(Time lhs, Time rhs)
	{
		return new Time(lhs.hours + rhs.hours, 
			            lhs.minutes + rhs.minutes);
	}

	public static Time operator+(Time t1, int minutes)
	{
		return t1 + new Time(minutes);
	}

	public static Time operator-(Time lhs, Time rhs)
	{
		return new Time(lhs.TotalMinutes() - rhs.TotalMinutes());
	}

	public static Time operator-(Time lhs, int minutes)
	{
		return new Time(lhs.TotalMinutes() - minutes);
	}

	public static Time operator++(Time t1)
	{
		return t1 + 1;
	}

	public static Time operator--(Time t1)
	{
		return t1 - 1;
	}

	// equality and relational

	public static bool operator==(Time lhs, Time rhs) 
	{
		return lhs.Compare(rhs) == 0;
	}

	public static bool operator!=(Time lhs, Time rhs) 
	{
		return lhs.Compare(rhs) != 0;
	}

    public static bool operator<(Time lhs, Time rhs) 
	{
		return lhs.Compare(rhs) < 0;
	}

    public static bool operator>(Time lhs, Time rhs) 
	{
		return lhs.Compare(rhs) > 0;
	}

    public static bool operator<=(Time lhs, Time rhs) 
	{
		return lhs.Compare(rhs) <= 0;
	}

    public static bool operator>=(Time lhs, Time rhs) 
	{
		return lhs.Compare(rhs) >= 0;
	}

	// conversions

	public static explicit operator Time (int minutes)
	{
		return new Time(0, minutes);
	}

	public static explicit operator Time (float minutes)
	{
		return new Time(0, (int)minutes);
	}

	public static implicit operator int (Time t1)
	{
		return t1.TotalMinutes();
	}

	public static explicit operator float (Time t1)
	{
		return t1.TotalMinutes();
	}

	public static implicit operator string (Time t1)
	{
		return t1.ToString();
	}

	// Inherited virtual methods (from Object)
	
	public override string ToString()
	{
		return String.Format("{0}:{1:00}", hours, minutes);
	}

	public override bool Equals(object obj)
	{
		return (obj is Time) && Compare((Time)obj) == 0;
	}

	public override int GetHashCode()
	{
		return TotalMinutes();
	}

	// Helper functions

	private int TotalMinutes()
	{
		return hours * 60 + minutes;
	}

	private int Compare(Time other)
	{
		long lhs = TotalMinutes();
		long rhs = other.TotalMinutes();
		
		int result;
		if (lhs < rhs)
			result = -1;
		else if (lhs > rhs)
			result = +1;
		else
			result = 0;

		return result;
	}

	private void Normalize()
	{
   		// This method normalizes the time.
		// For example if hours was 10 and minutes was 65, 
		// Normalize will change hours to 11 and minutes to 5
		if (minutes < 0 || hours < 0) {
			throw new ArgumentException("Time too small");
		}

		hours += (minutes / 60);
		minutes %= 60;
	}

	private int hours;
	private int minutes;
}
}
