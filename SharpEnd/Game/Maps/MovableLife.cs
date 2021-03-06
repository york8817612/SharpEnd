﻿using SharpEnd.Drawing;
using SharpEnd.Network;

namespace SharpEnd.Game.Maps
{
    public abstract class MovableLife
    {
        protected Point m_position;
        protected byte m_stance;
        protected short m_foothold;

        public Point Position { get { return m_position; } set { m_position = value; } }
        public byte Stance { get { return m_stance; } set { m_stance = value; } }
        public short Foothold { get { return m_foothold; } set { m_foothold = value; } }

        public bool ParseMovement(InPacket inPacket)
        {
            Point position = null;
            byte stance = 0;
            short foothold = 0;

            byte count = inPacket.ReadByte();

            while (count-- > 0)
            {
                byte type = inPacket.ReadByte();

                switch (type)
                {
                    case 0:
                    case 8:
                    case 15:
                    case 17:
                    case 19:
                    case 67:
                    case 68:
                    case 69:
                        {
                            position = inPacket.ReadPoint();
                            inPacket.ReadPoint();
                            foothold = inPacket.ReadShort();

                            if (type == 15 || type == 17)
                            {
                                inPacket.ReadShort();
                            }

                            inPacket.ReadPoint();
                            stance = inPacket.ReadByte();
                            inPacket.ReadShort();
                            inPacket.ReadBoolean();
                        }
                        break;

                    case 56:
                    case 66:
                    case 85:
                        {
                            position = inPacket.ReadPoint();
                            inPacket.ReadPoint();
                            foothold = inPacket.ReadShort();
                            stance = inPacket.ReadByte();
                            inPacket.ReadShort();
                            inPacket.ReadBoolean();
                        }
                        break;

                    case 1:
                    case 2:
                    case 18:
                    case 21:
                    case 22:
                    case 24:
                    case 62:
                    case 63:
                    case 64:
                    case 65:
                        {
                            inPacket.ReadPoint();

                            if (type == 21 || type == 2)
                            {
                                inPacket.ReadShort();
                            }

                            stance = inPacket.ReadByte();
                            inPacket.ReadShort();
                            inPacket.ReadBoolean();
                        }
                        break;

                    case 29:
                    case 30:
                    case 31:
                    case 32:
                    case 33:
                    case 34:
                    case 35:
                    case 36:
                    case 37:
                    case 38:
                    case 39:
                    case 40:
                    case 41:
                    case 42:
                    case 43:
                    case 44:
                    case 45:
                    case 46:
                    case 47:
                    case 48:
                    case 49:
                    case 50:
                    case 51:
                    case 57:
                    case 58:
                    case 59:
                    case 60:
                    case 70:
                    case 71:
                    case 72:
                    case 74:
                    case 79:
                    case 81:
                    case 83:
                        {
                            stance = inPacket.ReadByte();
                            inPacket.ReadShort();
                            inPacket.ReadBoolean();
                        }
                        break;

                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                    case 9:
                    case 10:
                    case 11:
                    case 13:
                    case 26:
                    case 27:
                    case 52:
                    case 53:
                    case 54:
                    case 61:
                    case 76:
                    case 77:
                    case 78:
                    case 80:
                    case 82:
                        {
                            position = inPacket.ReadPoint();
                            foothold = inPacket.ReadShort();
                            stance = inPacket.ReadByte();
                            inPacket.ReadShort();
                            inPacket.ReadBoolean();
                        }
                        break;

                    case 14:
                    case 16:
                        {
                            inPacket.ReadPoint();
                            inPacket.ReadShort();
                            stance = inPacket.ReadByte();
                            inPacket.ReadShort();
                            inPacket.ReadBoolean();
                        }
                        break;

                    case 23:
                        {
                            position = inPacket.ReadPoint();
                            inPacket.ReadPoint();
                            stance = inPacket.ReadByte();
                            inPacket.ReadShort();
                            inPacket.ReadBoolean();
                        }
                        break;

                    case 12:
                        {
                            inPacket.ReadByte();
                        }
                        break;

                    default: return false;
                }
            }

            if (position != null)
            {
                m_position = position;
                m_stance = stance;
                m_foothold = foothold;
            }

            return true;
        }
    }
}
