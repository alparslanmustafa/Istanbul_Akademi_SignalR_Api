﻿using System.Collections.Generic;

namespace Istanbul_Akademi_SignalR_Api.Models
{
	public class Room
	{
		public Room()
		{
			Users=new List<User>();
		}
		public int RoomID { get; set; }
		public string RoomName { get; set; }
		public List<User> Users { get; set; }
	}
}