﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjectsMap.WebApi.Models
{
    public class Seat
    {

		public Seat() { }

        public Seat(Employee employee, int xCoordinate, int yCoordinate)
        {
            Employee = employee;
            Vertex = new Vertex(xCoordinate, yCoordinate);
        }

		public Seat(Vertex seatVertex)
		{
			this.Vertex = seatVertex;
		}

		[Key]
        public int SeatId { get; set; }
        //Coordinate of the Seat on the given floor is described by (x,y) - left top corner of a square
        //One to one or zero relation (Vertex - Seat)
        public virtual Vertex Vertex { get; set; }

        //One to many relation(Room - Seats)
        public virtual Room Room { get; set; }
        public int RoomId { get; set; }

        //One-zero to many relation (Seat - Employee)
        public int? DeveloperId { get; set; }
        public int? DeveloperCompanyId { get; set; }
        public virtual Employee Employee { get; set; }
    }
}