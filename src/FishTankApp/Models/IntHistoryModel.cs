using System;

namespace FishTankApp.Models
{
	public class IntHistoryModel
	{
		public DateTime TimeStamp { get; set; }
		public int Value { get; set; }

		public IntHistoryModel(DateTime timeStamp, int value)
		{
			TimeStamp = timeStamp;
			Value = value;
		}
	}
}