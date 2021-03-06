﻿Module ServerTypes
    ' Public data structures
    Public Map(0 To MAX_MAPS) As MapRec
    Public MapCache(0 To MAX_MAPS) As Cache
    Public TempTile(0 To MAX_MAPS) As TempTileRec
    Public PlayersOnMap(0 To MAX_MAPS) As Long
    Public ResourceCache(0 To MAX_MAPS) As ResourceCacheRec
    Public Player(0 To MAX_PLAYERS) As PlayerRec
    Public Bank(0 To MAX_PLAYERS) As BankRec
    Public TempPlayer(0 To MAX_PLAYERS) As TempPlayerRec
    Public Classes() As ClassRec
    Public Item(0 To MAX_ITEMS) As ItemRec
    Public Npc(0 To MAX_NPCS) As NpcRec
    Public MapItem(0 To MAX_MAPS, 0 To MAX_MAP_ITEMS) As MapItemRec
    Public MapNpc(0 To MAX_MAPS) As MapDataRec
    Public Shop(0 To MAX_SHOPS) As ShopRec
    Public Skill(0 To MAX_SKILLS) As SkillRec
    Public Resource(0 To MAX_RESOURCES) As ResourceRec
    Public Animation(0 To MAX_ANIMATIONS) As AnimationRec
    Public Options As OptionsRec

    Public Structure OptionsRec
        Dim Game_Name As String
        Dim MOTD As String
        Dim Port As Long
        Dim Website As String
    End Structure

    Public Structure PlayerInvRec
        Dim Num As Byte
        Dim Value As Long

    End Structure

    Public Structure Cache
        Dim Data() As Byte
    End Structure

    Public Structure BankRec
        Dim Item() As PlayerInvRec
    End Structure

    Public Structure PlayerRec
        ' Account
        Dim Login As String
        Dim Password As String
        Dim Access As Byte

        'multi char
        Dim Character() As CharacterRec

    End Structure

    Public Structure CharacterRec
        ' General
        Dim Name As String
        Dim Sex As Byte
        Dim Classes As Byte
        Dim Sprite As Integer
        Dim Level As Byte
        Dim exp As Long

        Dim PK As Byte

        ' Vitals
        Dim Vital() As Long

        ' Stats
        Dim Stat() As Byte
        Dim POINTS As Byte

        ' Worn equipment
        Dim Equipment() As Byte

        ' Inventory
        Dim Inv() As PlayerInvRec
        Dim Skill() As Byte

        ' Position
        Dim Map As Integer
        Dim x As Byte
        Dim y As Byte
        Dim Dir As Byte

        Dim PlayerQuest() As PlayerQuestRec

        'Housing
        Dim House As PlayerHouseRec

        Dim InHouse As Long
        Dim LastMap As Long
        Dim LastX As Long
        Dim LastY As Long

        'Hotbar
        Dim Hotbar() As HotbarRec

        'Event
        Dim Switches() As Byte
        Dim Variables() As Long

        'gather skills
        Dim GatherSkills() As ResourceSkillsRec

        Dim RecipeLearned() As Byte
    End Structure

    Public Structure TempPlayerRec
        ' Non saved local vars
        Dim Buffer As ByteBuffer
        Dim InGame As Boolean
        Dim AttackTimer As Long
        Dim DataTimer As Long
        Dim DataBytes As Long
        Dim DataPackets As Long
        Dim PartyPlayer As Long
        Dim InParty As Byte
        Dim TargetType As Byte
        Dim Target As Byte
        Dim PartyStarter As Byte
        Dim GettingMap As Byte
        Dim SkillBuffer As Long
        Dim SkillBufferTimer As Long
        Dim SkillCD() As Long
        Dim InShop As Long
        Dim StunTimer As Long
        Dim StunDuration As Long
        Dim InBank As Boolean
        ' trade
        Dim TradeRequest As Long
        Dim InTrade As Long
        Dim TradeOffer() As PlayerInvRec
        Dim AcceptTrade As Boolean

        'Housing
        Dim BuyHouseIndex As Long

        Dim InvitationIndex As Long
        Dim InvitationTimer As Long

        Dim EventMap As EventMapRec
        Dim EventProcessingCount As Long
        Dim EventProcessing() As EventProcessingRec

        'multi char
        Dim CurChar As Byte

        'craft shit
        Dim IsCrafting As Boolean
        Dim CraftIt As Byte
        Dim CraftTimer As Long
        Dim CraftTimeNeeded As Long

        Dim CraftRecipe As Long
        Dim CraftAmount As Long
    End Structure

    Public Structure TileDataRec
        Dim X As Byte
        Dim Y As Byte
        Dim Tileset As Byte
        Dim Autotile As Byte
    End Structure

    Public Structure TileRec
        Dim Layer() As TileDataRec
        Dim Type As Byte
        Dim Data1 As Long
        Dim Data2 As Long
        Dim Data3 As Long
        Dim DirBlock As Byte
    End Structure

    Public Structure MapRec
        Dim Name As String
        Dim Music As String

        Dim Revision As Long
        Dim Moral As Byte
        Dim Tileset As Long

        Dim Up As Integer
        Dim Down As Integer
        Dim Left As Integer
        Dim Right As Integer

        Dim BootMap As Integer
        Dim BootX As Byte
        Dim BootY As Byte

        Dim MaxX As Byte
        Dim MaxY As Byte

        Dim Tile(,) As TileRec

        Dim Npc() As Integer

        Dim EventCount As Long
        Dim Events() As EventRec

        Dim WeatherType As Byte
        Dim FogIndex As Long
        Dim WeatherIntensity As Long
        Dim FogAlpha As Byte
        Dim FogSpeed As Byte

        Dim HasMapTint As Byte
        Dim MapTintR As Byte
        Dim MapTintG As Byte
        Dim MapTintB As Byte
        Dim MapTintA As Byte
    End Structure

    Public Structure ClassRec
        Dim Name As String
        Dim Desc As String
        Dim Stat() As Byte
        Dim MaleSprite() As Long
        Dim FemaleSprite() As Long
        Dim StartItem() As Long
        Dim StartValue() As Long
        Dim StartMap As Long
        Dim StartX As Byte
        Dim StartY As Byte
        Dim BaseExp As Long
    End Structure

    Public Structure ItemRec
        Dim Name As String
        Dim Pic As Integer
        Dim Description As String

        Dim Type As Byte
        Dim Data1 As Integer
        Dim Data2 As Integer
        Dim Data3 As Integer
        Dim ClassReq As Long
        Dim AccessReq As Long
        Dim LevelReq As Long
        Dim Mastery As Byte
        Dim price As Long
        Dim Add_Stat() As Byte
        Dim Rarity As Byte
        Dim Speed As Long
        Dim Handed As Long
        Dim BindType As Byte
        Dim Stat_Req() As Byte
        Dim Animation As Long
        Dim Paperdoll As Long

        Dim Randomize As Byte
        Dim RandomMin As Byte
        Dim RandomMax As Byte

        Dim Stackable As Byte

        'Housing
        Dim FurnitureWidth As Long
        Dim FurnitureHeight As Long
        Dim FurnitureBlocks(,) As Long
        Dim FurnitureFringe(,) As Long

        Dim KnockBack As Byte
        Dim KnockBackTiles As Byte
    End Structure

    Public Structure MapItemRec
        Dim Num As Byte
        Dim Value As Long
        Dim x As Byte
        Dim y As Byte

    End Structure

    Public Structure NpcRec
        Dim Name As String
        Dim AttackSay As String
        Dim Sprite As Long
        Dim SpawnSecs As Long
        Dim Behaviour As Byte
        Dim Range As Byte
        Dim DropChance() As Long
        Dim DropItem() As Long
        Dim DropItemValue() As Long
        Dim Stat() As Byte
        Dim Faction As Byte
        Dim HP As Long
        Dim Exp As Long
        Dim Animation As Long
        Dim QuestNum As Long
        Dim Skill() As Byte
    End Structure

    Public Structure MapNpcRec
        Dim Num As Integer
        Dim Target As Integer
        Dim TargetType As Byte
        Dim Vital() As Long
        Dim x As Byte
        Dim y As Byte
        Dim Dir As Integer
        ' For server use only
        Dim SpawnWait As Long
        Dim AttackTimer As Long
        Dim StunDuration As Long
        Dim StunTimer As Long
        Dim SkillBuffer As Long
        Dim SkillBufferTimer As Long
        Dim SkillCD() As Long
    End Structure

    Public Structure TradeItemRec
        Dim Item As Long
        Dim ItemValue As Long
        Dim costitem As Long
        Dim costvalue As Long
    End Structure

    Public Structure ShopRec
        Dim Name As String
        Dim Face As Byte
        Dim BuyRate As Long
        Dim TradeItem() As TradeItemRec
    End Structure

    Public Structure SkillRec
        Dim Name As String
        Dim Type As Byte
        Dim MPCost As Long
        Dim LevelReq As Long
        Dim AccessReq As Long
        Dim ClassReq As Long
        Dim CastTime As Long
        Dim CDTime As Long
        Dim Icon As Long
        Dim Map As Long
        Dim x As Long
        Dim y As Long
        Dim Dir As Byte
        Dim Vital As Long
        Dim Duration As Long
        Dim Interval As Long
        Dim range As Long
        Dim IsAoE As Boolean
        Dim AoE As Long
        Dim CastAnim As Long
        Dim SkillAnim As Long
        Dim StunDuration As Long

        'projectiles
        Dim IsProjectile As Long '0 is no, 1 is yes
        Dim Projectile As Long

        Dim KnockBack As Byte '0 is no, 1 is yes
        Dim KnockBackTiles As Byte
    End Structure

    Public Structure TempTileRec
        Dim DoorOpen(,) As Byte
        Dim DoorTimer As Long
    End Structure

    Public Structure MapDataRec
        Dim Npc() As MapNpcRec
    End Structure

    Public Structure MapResourceRec
        Dim ResourceState As Byte
        Dim ResourceTimer As Long
        Dim x As Long
        Dim y As Long
        Dim cur_health As Byte
    End Structure

    Public Structure ResourceCacheRec
        Dim Resource_Count As Long
        Dim ResourceData() As MapResourceRec
    End Structure

    Public Structure ResourceRec
        Dim Name As String
        Dim SuccessMessage As String
        Dim EmptyMessage As String
        Dim ResourceType As Long
        Dim ResourceImage As Long
        Dim ExhaustedImage As Long
        Dim ExpReward As Long
        Dim ItemReward As Long
        Dim LvlRequired As Long
        Dim ToolRequired As Long
        Dim Health As Long
        Dim RespawnTime As Long
        Dim Walkthrough As Boolean
        Dim Animation As Long
    End Structure

    Public Structure AnimationRec
        Dim Name As String
        Dim Sprite() As Long
        Dim Frames() As Long
        Dim LoopCount() As Long
        Dim LoopTime() As Long
    End Structure

    Public Structure HotbarRec
        Dim Slot As Long
        Dim sType As Byte
    End Structure

    Public Structure ResourceSkillsRec
        Dim SkillLevel As Long
        Dim SkillCurExp As Long
        Dim SkillNextLvlExp As Long
    End Structure
End Module
