﻿using MySql.Data.MySqlClient;
using SharpEnd.Maps;
using SharpEnd.Network;
using SharpEnd.Packets;
using SharpEnd.Utility;

namespace SharpEnd.Players
{
    internal sealed class Player : MovableLife
    {
        private Client m_client;

        public int Identifier { get; private set; }
        public string Name { get; private set; }
        public byte Gender { get; private set; }
        public byte Skin { get; private set; }
        public int Face { get; private set; }
        public int Hair { get; private set; }
        public int Map { get; private set; }
        public sbyte SpawnPoint { get; private set; }
        public byte PortalCount { get; set; }

        public PlayerStats Stats { get; private set; }
        public PlayerItems Items { get; private set; }
        public PlayerSkills Skills { get; private set; }
        public PlayerQuests Quests { get; private set; }

        public Player(Client client, DatabaseQuery query)
        {
            m_client = client;

            Identifier = query.Get<int>("identifier");
            Name = query.Get<string>("name");
            Gender = query.Get<byte>("gender");
            Skin = query.Get<byte>("skin");
            Face = query.Get<int>("face");
            Hair = query.Get<int>("hair");
            Map = query.Get<int>("map_identifier");
            SpawnPoint = query.Get<sbyte>("map_spawn");

            Stats = new PlayerStats(this, query);

            using (DatabaseQuery itemQuery = Database.Query("SELECT * FROM player_item WHERE player_identifier=@player_identifier", new MySqlParameter("player_identifier", Identifier)))
            {
                long meso = query.Get<long>("meso");

                byte equipmentSlots = query.Get<byte>("equipment_slots");
                byte usableSlots = query.Get<byte>("usable_slots");
                byte setupSlots = query.Get<byte>("setup_slots");
                byte etceteraSlots = query.Get<byte>("etcetera_slots");
                byte cashSlots = query.Get<byte>("cash_slots");

                Items = new PlayerItems(this, itemQuery, meso, equipmentSlots, usableSlots, setupSlots, etceteraSlots, cashSlots);
            }

            using (DatabaseQuery skillQuery = Database.Query("SELECT * FROM player_skill WHERE player_identifier=@player_identifier", new MySqlParameter("player_identifier", Identifier)))
            {
                Skills = new PlayerSkills(this, query);
            }

            using (DatabaseQuery questQuery = Database.Query("SELECT * FROM player_quest WHERE player_identifier=@player_identifier", new MySqlParameter("player_identifier", Identifier)))
            {
                Quests = new PlayerQuests(this, query);
            }
        }

        public void Save()
        {
            Items.Save();
            Skills.Save();
            Quests.Save();
        }

        public void Notify(string text, EMessageType type = EMessageType.Pink)
        {
            m_client.Send(MessagePackets.Notification(text, type));
        }
    }
}
