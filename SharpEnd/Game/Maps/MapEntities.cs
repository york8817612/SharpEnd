﻿using System.Collections.Generic;

namespace SharpEnd.Game.Maps
{
    internal abstract class MapEntities<T> : Dictionary<int, T> where T : MapEntity
    {
        public Map Map { get; private set; }

        public MapEntities(Map map)
            : base()
        {
            Map = map;
        }

        public virtual void Add(T entity)
        {
            entity.Map = Map;
            entity.ObjectIdentifier = Map.AssignObjectIdentifier();

            Add(entity.ObjectIdentifier, entity);
        }

        public virtual void Remove(T entity)
        {
            Remove(entity.ObjectIdentifier);

            entity.Map = null;
            entity.ObjectIdentifier = -1;
        }
    }
}