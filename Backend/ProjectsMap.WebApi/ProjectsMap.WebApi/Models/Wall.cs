﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectsMap.WebApi.Models
{
    public class Wall
    {
		private Vertex start;
		private Vertex end;

		public Wall(Vertex start, Vertex end)
		{
			this.StartVertex = start;
			this.EndVertex = end;
		}

		public Wall()
		{
		}

		[Key]
        public int WallId { get; set; }

        public int? StartVertexX { get; set; }
        public int? StartVertexY { get; set; }
        public virtual Vertex StartVertex { get; set; }

        public int? EndVertexX { get; set; }
        public int? EndVertexY { get; set; }
        public virtual Vertex EndVertex { get; set; }

        public virtual ICollection<Room> Rooms { get; set; }

        public int? FloorId { get; set; }
        public virtual Floor Floor { get; set; }

    }
}