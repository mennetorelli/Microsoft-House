﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;
using MicrosoftHouse.Abstractions;

namespace MicrosoftHouse.Services
{
	public class AzureCloudTable<T> : ICloudTable<T> where T : TableData
	{
		MobileServiceClient client;
		IMobileServiceTable<T> table;

		public AzureCloudTable(MobileServiceClient client)
		{
			this.client = client;
			this.table = client.GetTable<T>();
		}

		// CREATE
		public async Task<T> CreateEventAsynch(T newEvent)
		{
			await table.InsertAsync(newEvent);
			return newEvent;
		}

		public Task<T> CreateEventLocationAsynch(T room)
		{
			throw new NotImplementedException();
		}

		public Task<T> CreateParkAsynch(T room)
		{
			throw new NotImplementedException();
		}

		public async Task<T> CreateReservationAsynch(T reservation)
		{
			await table.InsertAsync(reservation);
			return reservation;
		}

		public async Task<T> CreateRoomAsynch(T room)
		{
			await table.InsertAsync(room);
			return room;
		}

		// DELETE
		public async Task DeleteEventAsync(T currentEvent)
		{
			await table.DeleteAsync(currentEvent);
		}

		public Task DeleteEventLocationAsync(T room)
		{
			throw new NotImplementedException();
		}

		public Task DeleteParkAsync(T room)
		{
			throw new NotImplementedException();
		}

		public async Task DeleteReservationAsync(T reservation)
		{
			await table.DeleteAsync(reservation);
		}

		public async Task DeleteRoomAsync(T room)
		{
			await table.DeleteAsync(room);
		}


		// READ ALL
		public async Task<ICollection<T>> ReadAllEventLocationsAsync()
		{
			return await table.ToListAsync();
		}

		public async Task<ICollection<T>> ReadAllEventsAsync()
		{
			return await table.ToListAsync();
		}

		public async Task<ICollection<T>> ReadAllParksAsync()
		{
			return await table.ToListAsync();
		}

		public async Task<ICollection<T>> ReadAllReservationsAsync()
		{
			return await table.ToListAsync();
		}

		public async Task<ICollection<T>> ReadAllRoomsAsync()
		{
			return await table.ToListAsync();
		}


		// READ
		public async Task<T> ReadEventAsync(string id)
		{
			return await table.LookupAsync(id);
		}

		public async Task<T> ReadEventLocationAsync(string id)
		{
			return await table.LookupAsync(id);
		}

		public async Task<T> ReadParkAsync(string id)
		{
			return await table.LookupAsync(id);
		}

		public async Task<T> ReadReservationAsync(string id)
		{
			return await table.LookupAsync(id);
		}

		public async Task<T> ReadRoomAsync(string id)
		{
			return await table.LookupAsync(id);
		}

		// UPDATE
		public async Task<T> UpdateEventAsync(T currentEvent)
		{
			await table.UpdateAsync(currentEvent);
			return currentEvent;
		}

		public Task<T> UpdateEventLocationAsync(T room)
		{
			throw new NotImplementedException();
		}

		public async Task<T> UpdateParkAsync(T park)
		{
			await table.UpdateAsync(park);
			return park;
		}

		public async Task<T> UpdateReservationAsync(T reservation)
		{
			await table.UpdateAsync(reservation);
			return reservation;
		}

		public async Task<T> UpdateRoomAsync(T room)
		{
			await table.UpdateAsync(room);
			return room;
		}
	}
}
