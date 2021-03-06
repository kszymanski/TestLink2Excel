﻿using System.Collections.Generic;
using System.ComponentModel;

namespace TestLink2Excel.Model
{
	public class TestCase : INotifyPropertyChanged
	{
		#region Fields

		private string name;

		#endregion

		#region Propertes

		public int ExternalId { get; set; }
		public int InternalId { get; set; }

		public string Name
		{
			get
			{
				return this.name;
			}
			set
			{
				this.name = value;
				this.NotifyPropertyChanged("Name");
			}
		}

		public string Summary { get; set; }
		public string Preconditions { get; set; }
		public List<Step> Steps { get; set; }
		public event PropertyChangedEventHandler PropertyChanged;

		#endregion

		#region Constructors

		public TestCase(string name)
		{
			Name = name;
			Steps = new List<Step>();
		}

		#endregion

		private void NotifyPropertyChanged(string info)
		{
			if (PropertyChanged != null)
				PropertyChanged(this, new PropertyChangedEventArgs(info));
		}
	}
}
