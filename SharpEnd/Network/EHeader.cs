﻿namespace SharpEnd.Network
{
    internal enum EHeader : ushort
    {
        CMSG_GUEST_LOGIN =                      0x0016,
        CMSG_TOS =                              0x001D,
        CMSG_PART_TIME_JOB =                    0x003C,
        CMSG_VERSION_INFORMATION =              0x0067,
        CMSG_AUTHENTICATION =                   0x0069,
        CMSG_PLAYER_LIST =                      0x006A,
        CMSG_PLAYER_SELECT_PIC =                0x006B,
        CMSG_PLAYER_SELECT =                    0x006F,
        CMSG_WORLD_LIST_RELIST =                0x0072,
        CMSG_PLAYER_NAME_CHECK =                0x0074,
        CMSG_PLAYER_CREATE =                    0x007D,
        CMSG_PLAYER_DELETE =                    0x0080,
        CMSG_PRIVATE_SERVER_AUTH =              0x0086,
        CMSG_PONG =                             0x0093,
        CMSG_CLIENT_ERROR =                     0x0095,
        CMSG_CLIENT_START =                     0x0098,
        CMSG_STRANGE_DATA =                     0x009A,
        CMSG_WORLD_STATUS =                     0x009D,
        CMSG_WORLD_LIST =                       0x00A2,
        CMSG_PIC_CHANGE =                       0x00AA,
        CMSG_AUTH_SERVER =                      0x00AB,
        CMSG_BUTTON_PRESS =                     0x024B,

        SMSG_AUTHENTICATION =                   0x0000,
        SMSG_WORLD_INFORMATION =                0x0001,
        SMSG_RECOMMENDED_WORLD =                0x0002,
        SMSG_PLAYER_LIST =                      0x0006,
        SMSG_SERVER_IP =                        0x0007,
        SMSG_PLAYER_NAME_CHECK =                0x000A,
        SMSG_PLAYER_CREATE =                    0x000B,
        SMSG_PLAYER_DELETE =                    0x000C,
        SMSG_PING =                             0x0012,
        SMSG_PRIVATE_SERVER_AUTH =              0x0017,
        SMSG_PIC_CHANGE =                       0x0019,
        SMSG_PART_TIME_JOB =                    0x001D,
        SMSG_START =                            0x0024,
        SMSG_WORLD_STATUS =                     0x0026,
        SMSG_AUTH_SERVER =                      0x002F,

        CMSG_CHANGE_MAP =                       0x00AF,
        CMSG_CHANGE_CHANNEL =                   0x00B0,
        CMSG_CASH_SHOP =                        0x00B4,
        CMSG_MONSTER_LIFE =                     0x00B7,
        CMSG_PLAYER_MOVE =                      0x00BE,
        CMSG_SIT =                              0x00BF,
        CMSG_ATTACK_MELEE =                     0x00C3,
        CMSG_ATTACK_RANGED =                    0x00C4,
        CMSG_ATTACK_MAGIC =                     0x00C5,
        CMSG_ATTACK_ENERGY_CHARGE =             0x00C6,
        CMSG_PLAYER_HIT =                       0x00C9,
        CMSG_PLAYER_CHAT =                      0x00CB,
        CMSG_PLAYER_EMOTE =                     0x00CD,
        CMSG_NPC_CONVERSE =                     0x00DD,
        CMSG_NPC_CONVERSE_RESULT =              0x00DF,
        CMSG_NPC_SHOP =                         0x00E0,
        CMSG_NPC_STORAGE =                      0x00E1,
        CMSG_INVENTORY_SORT =                   0x00EF,
        CMSG_INVENTORY_GATHER =                 0x00F0,
        CMSG_INVENTORY_OPERATION =              0x00F1,
        CMSG_PLAYER_LOAD =                      0x006E,
        CMSG_STAT_ADD =                         0x012A,
        CMSG_STAT_ADD_MULTI =                   0x012B,
        CMSG_PLAYER_HEAL =                      0x012D,
        CMSG_SKILL_ADD =                        0x0130,
        CMSG_SKILL_USE =                        0x0131,
        CMSG_INVENTORY_MESO_DROP =              0x0134,
        CMSG_PLAYER_DETAILS =                   0x0137,
        CMSG_CHANGE_MAP_SCRIPTED =              0x013B,
        CMSG_INSTANT_WARP =                     0x013C,
        CMSG_QUEST =                            0x0144,
        CMSG_SPECIAL_STAT =                     0x015C,
        CMSG_PARTY_ALLOW_INVITE =               0x0186,
        CMSG_KEYMAP =                           0x019E,
        CMSG_MOB_MOVE =                         0x0339,
        CMSG_NPC_ACTION =                       0x0353,
        CMSG_INVENTORY_PICKUP =                 0x0358,

        SMSG_INVENTORY_OPERATION =              0x0047,
        SMSG_INVENTORY_GROW =                   0x0048,
        SMSG_PLAYER_UPDATE =                    0x0049,
        SMSG_BUFF =                             0x004A,
        SMSG_BUFF_CANCEL =                      0x004B,
        SMSG_TEMPORARY_STATS =                  0x004C,
        SMSG_TEMPORARY_STATS_RESET =            0x004D,
        SMSG_SKILL_ADD =                        0x004E,
        SMSG_SHOW_LOG =                         0x0059,
        SMSG_PLAYER_DETAILS =                   0x0071,
        SMSG_NOTIFICATION =                     0x0082,
        SMSG_YELLOW_MESSAGE =                   0x00B7,
        SMSG_MAP_WEATHER =                      0x00BB,
        SMSG_SPECIAL_STAT =                     0x00C6,
        SMSG_EVENT_LIST =                       0x0114,
        SMSG_EVENT_NAME_TAG_INFO =              0x0118,
        SMSG_MAP_CHANGE =                       0x01AC,
        SMSG_CLOCK =                            0x01C5,
        SMSG_PLAYER_SPAWN =                     0x0204,
        SMSG_PLAYER_DESPAWN =                   0x0205,
        SMSG_PLAYER_CHAT =                      0x0206,
        SMSG_CHALKBOARD =                       0x0207,
        SMSG_SIT =                              0x022B,
        SMSG_PLAYER_MOVE =                      0x0279,
        SMSG_ATTACK_MELEE =                     0x027A,
        SMSG_ATTACK_RANGED =                    0x027B,
        SMSG_ATTACK_MAGIC =                     0x027C,
        SMSG_ATTACK_ENERGY_CHARGE =             0x027D,
        SMSG_QUEST =                            0x02B4,
        SMSG_MOB_SPAWN =                        0x038C,
        SMSG_MOB_DESPAWN =                      0x038D,
        SMSG_MOB_CONTROL =                      0x038E,
        SMSG_MOB_MOVE =                         0x0392,
        SMSG_MOB_CONTROL_ACK =                  0x0393,
        SMSG_MOB_STATUS =                       0x0395,
        SMSG_MOB_STATUS_REMOVE =                0x0396,
        SMSG_MOB_HIT =                          0x0399,
        SMSG_MOB_HEALTH =                       0x039E,
        SMSG_NPC_SPAWN =                        0x03D8,
        SMSG_NPC_DESPAWN =                      0x03D9,
        SMSG_NPC_CONTROL =                      0x03DB,
        SMSG_NPC_ACTION =                       0x03DC,
        SMSG_DROP_SPAWN =                       0x03F1,
        SMSG_DROP_DESPAWN =                     0x03F3,
        SMSG_REACTOR_TRIGGER =                  0x0402,
        SMSG_REACTOR_MOVE =                     0x0403,
        SMSG_REACTOR_SPAWN =                    0x0404,
        SMSG_REACTOR_DESPAWN =                  0x0405,
        SMSG_NPC_DIALOG =                       0x0501,
        SMSG_KEYMAP =                           0x0591,
        SMSG_PET_AUTO_HEALTH =                  0x0592,
        SMSG_PET_AUTO_MANA =                    0x0593,
        SMSG_PET_AUTO_CURE =                    0x0594,
    }
}
