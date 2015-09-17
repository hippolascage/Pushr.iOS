using System;

namespace Pushr.iOS
{
	public class Counter
	{
		private int count = 0;

		public Counter ()
		{
			this.count = 0;
		}

		public void IncrementCount() {
			this.count++;
		}

		public int GetCount() {
			return this.count;
		}

		public String GetCountAsString() {
			return this.count.ToString ();
		}

		public void ResetCount() {
			this.count = 0;
		}
}
}