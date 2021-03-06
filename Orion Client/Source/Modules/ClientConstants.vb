﻿Module ClientConstants

    'Graphics
    Public Const FPS_LIMIT As Long = 64

    'Chatbubble
    Public Const ChatBubbleWidth As Long = 200

    Public Const EFFECT_TYPE_FADEIN As Long = 1
    Public Const EFFECT_TYPE_FADEOUT As Long = 2
    Public Const EFFECT_TYPE_FLASH As Long = 3
    Public Const EFFECT_TYPE_FOG As Long = 4
    Public Const EFFECT_TYPE_WEATHER As Long = 5
    Public Const EFFECT_TYPE_TINT As Long = 6

    Public Const MAX_BYTE As Byte = 255
    Public Const MAX_INTEGER As Integer = 32767
    Public Const MAX_LONG As Long = 2147483647

    ' path constants
    Public Const SOUND_PATH As String = "\Data Files\sound\"
    Public Const MUSIC_PATH As String = "\Data Files\music\"

    ' Font variables
    Public Const FONT_NAME As String = "Arvo-Regular.ttf"
    Public Const FONT_SIZE As Byte = 13

    ' Log Path and variables
    Public Const LOG_DEBUG As String = "debug.txt"
    Public Const LOG_PATH As String = "\Data Files\logs\"

    ' Map Path and variables
    Public Const MAP_PATH As String = "\Data Files\maps\"
    Public Const MAP_EXT As String = ".map"

    ' Gfx Path and variables
    Public Const GFX_PATH As String = "\Data Files\graphics\"
    Public Const GFX_GUI_PATH As String = "\Data Files\graphics\gui\"
    Public Const GFX_EXT As String = ".png"

    ' Key constants
    'Public Const VK_UP As Long = &H26
    'Public Const VK_DOWN As Long = &H28
    'Public Const VK_LEFT As Long = &H25
    'Public Const VK_RIGHT As Long = &H27
    'Public Const VK_SHIFT As Long = &H10
    'Public Const VK_RETURN As Long = &HD
    'Public Const VK_CONTROL As Long = &H11

    ' Menu states
    Public Const MENU_STATE_NEWACCOUNT As Byte = 0
    Public Const MENU_STATE_DELACCOUNT As Byte = 1
    Public Const MENU_STATE_LOGIN As Byte = 2
    Public Const MENU_STATE_GETCHARS As Byte = 3
    Public Const MENU_STATE_NEWCHAR As Byte = 4
    Public Const MENU_STATE_ADDCHAR As Byte = 5
    Public Const MENU_STATE_DELCHAR As Byte = 6
    Public Const MENU_STATE_USECHAR As Byte = 7
    Public Const MENU_STATE_INIT As Byte = 8

    ' Number of tiles in width in tilesets
    Public Const TILESHEET_WIDTH As Integer = 15 ' * PIC_X pixels

    Public MapGrid As Boolean

    ' Speed moving vars
    Public Const WALK_SPEED As Byte = 6
    Public Const RUN_SPEED As Byte = 10

    ' Tile size constants
    Public Const PIC_X As Integer = 32
    Public Const PIC_Y As Integer = 32

    ' Sprite, item, skill size constants
    Public Const SIZE_X As Integer = 32
    Public Const SIZE_Y As Integer = 32

    ' ********************************************************
    ' * The values below must match with the server's values *
    ' ********************************************************

    ' General constants
    Public Const GAME_NAME As String = "Orion+"

    ' Website
    Public Const GAME_WEBSITE As String = "http://ascensiongamedev.com/index.php"

    ' Account constants
    Public Const NAME_LENGTH As Byte = 20

    ' Sex constants
    'Public Const SEX_MALE As Byte = 0
    'Public Const SEX_FEMALE As Byte = 1

    ' Map constants
    Public MAX_MAPX As Byte = 35
    Public MAX_MAPY As Byte = 26

    'Public Const MAP_MORAL_NONE As Byte = 0
    'Public Const MAP_MORAL_SAFE As Byte = 1
    'Public Const MAP_MORAL_INDOOR As Byte = 2

    '' Tile consants
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
    ''craft
    'Public Const TILE_TYPE_CRAFT As Byte = 15

    ' Item constants
    'Public Const ITEM_TYPE_NONE As Byte = 0
    'Public Const ITEM_TYPE_WEAPON As Byte = 1
    'Public Const ITEM_TYPE_ARMOR As Byte = 2
    'Public Const ITEM_TYPE_HELMET As Byte = 3
    'Public Const ITEM_TYPE_SHIELD As Byte = 4
    'Public Const ITEM_TYPE_SHOES As Byte = 5
    'Public Const ITEM_TYPE_GLOVES As Byte = 6
    'Public Const ITEM_TYPE_POTIONADDHP As Byte = 7
    'Public Const ITEM_TYPE_POTIONADDMP As Byte = 8
    'Public Const ITEM_TYPE_POTIONADDSP As Byte = 9
    'Public Const ITEM_TYPE_POTIONSUBHP As Byte = 10
    'Public Const ITEM_TYPE_POTIONSUBMP As Byte = 11
    'Public Const ITEM_TYPE_POTIONSUBSP As Byte = 12
    'Public Const ITEM_TYPE_KEY As Byte = 13
    'Public Const ITEM_TYPE_CURRENCY As Byte = 14
    'Public Const ITEM_TYPE_SKILL As Byte = 15
    'Public Const ITEM_TYPE_FURNITURE As Byte = 16
    'Public Const ITEM_TYPE_RECIPES As Byte = 17

    Public ITEM_RARITY_COLOR_0 = SFML.Graphics.Color.White ' white
    Public ITEM_RARITY_COLOR_1 = New SFML.Graphics.Color(102, 255, 0) ' green
    Public ITEM_RARITY_COLOR_2 = New SFML.Graphics.Color(73, 151, 208) ' blue
    Public ITEM_RARITY_COLOR_3 = New SFML.Graphics.Color(128, 0, 0) ' red
    Public ITEM_RARITY_COLOR_4 = New SFML.Graphics.Color(159, 0, 197) ' purple
    Public ITEM_RARITY_COLOR_5 = New SFML.Graphics.Color(255, 215, 0) ' gold

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

    ' Constants for player movement: Tiles per Second
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
    Public Const EDITOR_RESOURCE As Byte = 5
    Public Const EDITOR_ANIMATION As Byte = 6
    Public Const EDITOR_QUEST As Byte = 7
    Public Const EDITOR_HOUSE As Byte = 8
    Public Const EDITOR_RECIPE As Byte = 9
    Public Const EDITOR_CLASSES As Byte = 10

    ' Target type constants
    Public Const TARGET_TYPE_NONE As Byte = 0
    Public Const TARGET_TYPE_PLAYER As Byte = 1
    Public Const TARGET_TYPE_NPC As Byte = 2
    Public Const TARGET_TYPE_EVENT As Byte = 3
    Public HalfX As Integer = ((MAX_MAPX + 1) \ 2) * PIC_X
    Public HalfY As Integer = ((MAX_MAPY + 1) \ 2) * PIC_Y
    Public ScreenX As Integer = (MAX_MAPX + 1) * PIC_X
    Public ScreenY As Integer = (MAX_MAPY + 1) * PIC_Y

    ' Do Events
    Public Const nLng As Long = (&H80 Or &H1 Or &H4 Or &H20) + (&H8 Or &H40)

    ' Scrolling action message constants
    Public Const ACTIONMSG_STATIC As Long = 0
    Public Const ACTIONMSG_SCROLL As Long = 1
    Public Const ACTIONMSG_SCREEN As Long = 2

    'dialog types
    Public Const DIALOGUE_TYPE_BUYHOME As Byte = 1
    Public Const DIALOGUE_TYPE_VISIT As Byte = 2
    Public Const DIALOGUE_TYPE_PARTY As Byte = 3
    Public Const DIALOGUE_TYPE_QUEST As Byte = 4
    Public Const DIALOGUE_TYPE_TRADE As Byte = 5

End Module
