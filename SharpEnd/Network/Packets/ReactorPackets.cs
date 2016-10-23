﻿using SharpEnd.Game.Life;
using SharpEnd.Network;

namespace SharpEnd.Packets
{
    public static class ReactorPackets
    {
        public static byte[] ReactorSpawn(Reactor reactor)
        {
            using (OutPacket outPacket = new OutPacket())
            {
                outPacket
                    .WriteHeader(EHeader.SMSG_REACTOR_SPAWN)
                    .WriteInt(reactor.ObjectID)
                    .WriteInt(reactor.Id)
                    .WriteByte() // TODO: State.
                    .WritePoint(reactor.Position)
                    .WriteByte(reactor.Stance)
                    .WriteString(reactor.Label);

                return outPacket.ToArray();
            }
        }
    }
}
