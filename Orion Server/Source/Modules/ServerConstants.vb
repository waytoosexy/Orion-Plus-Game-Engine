﻿Module ServerConstants

    ' Path constants
    Public Const ADMIN_LOG As String = "admin.log"
    Public Const PLAYER_LOG As String = "player.log"

    ' Version constants
    Public Const CLIENT_MAJOR As Byte = 4
    Public Const CLIENT_MINOR As Byte = 0
    Public Const CLIENT_REVISION As Byte = 0
    Public Const MAX_LINES As Integer = 500 ' Used for frmServer.txtText

    Public jcs As Long

    Public MAX_CHARS As Byte = 3

    ' ********************************************************
    ' * The values below must match with the client's values *
    ' ********************************************************
    ' General constants
    Public Const MAX_HOTBAR As Byte = 7

    ' Boolean constants
    Public Const NO As Byte = 0
    Public Const YES As Byte = 1

    ' Account constants
    Public Const NAME_LENGTH As Byte = 20

    ' Sex constants
    'Public Const SEX_MALE As Byte = 0
    'Public Const SEX_FEMALE As Byte = 1

    Public Const StatPtsPerLvl As Byte = 3

    ' Map constants
    'Public Const MAX_MAPS As Long = 100
    Public Const MAX_MAPX As Byte = 50
    Public Const MAX_MAPY As Byte = 50

    'Public Const MAP_MORAL_NONE As Byte = 0
    'Public Const MAP_MORAL_SAFE As Byte = 1
    'Public Const MAP_MORAL_INDOOR As Byte = 2

    ' Tile consants
    'Public Const TILE_TYPE_WALKABLE As Byte = 0
    'Public Const TILE_TYPE_BLOCKED As Byte = 1
    'Public Const TILE_TYPE_WARP As Byte = 2
    'Public Const TILE_TYPE_ITEM As Byte = 3
    'Public Const TILE_TYPE_NPCAVOID As Byte = 4
    'Public Const TILE_TYPE_KEY As Byte = 5
    'Public Const TILE_TYPE_KEYOPEN As Byte = 6
    'Public Const TILE_TYPE_RESOURCE As Byte = 7
    'Public Const TILE_TYPE_DOOR As Byte = 8
    'Public Const TILE_TYPE_NPCSPAWN As Byte = 9
    'Public Const TILE_TYPE_SHOP As Byte = 10
    'Public Const TILE_TYPE_BANK As Byte = 11
    'Public Const TILE_TYPE_HEAL As Byte = 12
    'Public Const TILE_TYPE_TRAP As Byte = 13
    ''Housing
    'Public Const TILE_TYPE_HOUSE As Byte = 14

    ' Item constants
    'Public Const ItemType.NONE As Byte = 0
    'Public Const ItemType.WEAPON As Byte = 1
    'Public Const ItemType.ARMOR As Byte = 2
    'Public Const ItemType.HELMET As Byte = 3
    'Public Const ItemType.SHIELD As Byte = 4
    'Public Const ItemType.SHOES As Byte = 5
    'Public Const ItemType.GLOVES As Byte = 6
    'Public Const ItemType.POTIONADDHP As Byte = 7
    'Public Const ItemType.POTIONADDMP As Byte = 8
    'Public Const ItemType.POTIONADDSP As Byte = 9
    'Public Const ItemType.POTIONSUBHP As Byte = 10
    'Public Const ItemType.POTIONSUBMP As Byte = 11
    'Public Const ItemType.POTIONSUBSP As Byte = 12
    'Public Const ItemType.KEY As Byte = 13
    'Public Const ItemType.CURRENCY As Byte = 14
    'Public Const ItemType.SKILL As Byte = 15
    'Public Const ItemType.FURNITURE As Byte = 16

    'resource Constants
    Public Const RESOURCE_TYPE_NONE As Byte = 0
    Public Const RESOURCE_TYPE_HERB As Byte = 1
    Public Const RESOURCE_TYPE_TREE As Byte = 2
    Public Const RESOURCE_TYPE_ROCK As Byte = 3
    Public Const RESOURCE_TYPE_FISH As Byte = 4

    Public Const RESOURCE_TOOL_NONE As Byte = 0
    Public Const RESOURCE_TOOL_HATCHET As Byte = 1
    Public Const RESOURCE_TOOL_PICKAXE As Byte = 2
    Public Const RESOURCE_TOOL_FISHROD As Byte = 3

    ' Direction constants
    Public Const DIR_UP As Byte = 0
    Public Const DIR_DOWN As Byte = 1
    Public Const DIR_LEFT As Byte = 2
    Public Const DIR_RIGHT As Byte = 3

    ' Constants for player movement
    Public Const MOVING_WALKING As Byte = 1
    Public Const MOVING_RUNNING As Byte = 2

    ' Admin constants
    Public Const ADMIN_MONITOR As Byte = 1
    Public Const ADMIN_MAPPER As Byte = 2
    Public Const ADMIN_DEVELOPER As Byte = 3
    Public Const ADMIN_CREATOR As Byte = 4

    ' NPC constants
    Public Const NPC_BEHAVIOUR_ATTACKONSIGHT As Byte = 0
    Public Const NPC_BEHAVIOUR_ATTACKWHENATTACKED As Byte = 1
    Public Const NPC_BEHAVIOUR_FRIENDLY As Byte = 2
    Public Const NPC_BEHAVIOUR_SHOPKEEPER As Byte = 3
    Public Const NPC_BEHAVIOUR_GUARD As Byte = 4
    Public Const NPC_BEHAVIOUR_QUEST As Byte = 5

    ' Skill constants
    Public Const SKILL_TYPE_DAMAGEHP As Byte = 0
    Public Const SKILL_TYPE_DAMAGEMP As Byte = 1
    Public Const SKILL_TYPE_HEALHP As Byte = 2
    Public Const SKILL_TYPE_HEALMP As Byte = 3
    Public Const SKILL_TYPE_WARP As Byte = 4

    ' Game editor constants
    Public Const EDITOR_ITEM As Byte = 1
    Public Const EDITOR_NPC As Byte = 2
    Public Const EDITOR_SKILL As Byte = 3
    Public Const EDITOR_SHOP As Byte = 4

    ' Target type constants
    Public Const TARGET_TYPE_NONE As Byte = 0
    Public Const TARGET_TYPE_PLAYER As Byte = 1
    Public Const TARGET_TYPE_NPC As Byte = 2
    Public Const TARGET_TYPE_EVENT As Byte = 3

    ' ********************************************
    ' Default starting location [Server Only]
    Public Const START_MAP As Integer = 1
    Public Const START_X As Integer = 13
    Public Const START_Y As Integer = 7

    ' Scrolling action message constants
    Public Const ACTIONMSG_STATIC As Long = 0
    Public Const ACTIONMSG_SCROLL As Long = 1
    Public Const ACTIONMSG_SCREEN As Long = 2

    ' Do Events
    Public Const nLng As Long = (&H80 Or &H1 Or &H4 Or &H20) + (&H8 Or &H40)

End Module
