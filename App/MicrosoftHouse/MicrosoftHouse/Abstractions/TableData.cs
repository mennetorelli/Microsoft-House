﻿using System;
namespace MicrosoftHouse.Abstractions
{
	public abstract class TableData
	{
		public string Id { get; set; }
		public DateTimeOffset? UpdatedAt { get; set; }
		public DateTimeOffset? CreatedAt { get; set; }
		public byte[] Version { get; set; }
	}
}
