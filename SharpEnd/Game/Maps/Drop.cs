﻿using SharpEnd.Drawing;
using SharpEnd.Players;
using SharpEnd.Threading;

namespace SharpEnd.Game.Maps
{
    internal abstract class Drop : MapEntity
    {
        private MapEntity dropper;
        
        public Player Owner { get; set; }
        public Point Origin { get; set; }
        public Delay Expiry { get; set; }

        public MapEntity Dropper
        {
            get
            {
                return dropper;
            }
            set
            {
                Origin = value.Position;
                Position = value.Map.Footholds.FindFloor(value.Position, -100);

                dropper = value;
            }
        }

        public Drop() : base() { }
    }
}