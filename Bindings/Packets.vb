﻿Module Packets
    ' Packets sent by server to client
    Public Enum ServerPackets
        SAlertMsg = 1
        SLoginOk
        SSelChar
        SNewCharClasses
        SClassesData
        SInGame
        SPlayerInv
        SPlayerInvUpdate
        SPlayerWornEq
        SPlayerHp
        SPlayerMp
        SPlayerSp
        SPlayerStats
        SPlayerData
        SPlayerMove
        SNpcMove
        SPlayerDir
        SNpcDir
        SPlayerXY
        SAttack
        SNpcAttack
        SCheckForMap
        SMapData
        SMapItemData
        SMapNpcData
        SMapNpcUpdate
        SMapDone
        SGlobalMsg
        SAdminMsg
        SPlayerMsg
        SMapMsg
        SSpawnItem
        SItemEditor
        SUpdateItem
        SREditor
        SSpawnNpc
        SNpcDead
        SNpcEditor
        SUpdateNpc
        SMapKey
        SEditMap
        SShopEditor
        SUpdateShop
        SSkillEditor
        SUpdateSkill
        SSkills
        SLeftMap
        SResourceCache
        SResourceEditor
        SUpdateResource
        SSendPing
        SDoorAnimation
        SActionMsg
        SPlayerEXP
        SBlood
        SAnimationEditor
        SUpdateAnimation
        SAnimation
        SMapNpcVitals
        SCooldown
        SClearSkillBuffer
        SSayMsg
        SOpenShop
        SResetShopAction
        SStunned
        SMapWornEq
        SBank

        SClearTradeTimer
        STradeInvite
        STrade
        SCloseTrade
        STradeUpdate
        STradeStatus

        SGameData
        SMapReport
        STarget
        SAdmin
        SMapNames
        SCritical
        SNews
        SrClick

        'quests
        SQuestEditor
        SUpdateQuest
        SPlayerQuest
        SPlayerQuests
        SQuestMessage

        'Housing
        SBuyHouse
        SVisit
        SFurniture
        SHouseEdit
        SHouseConfigs

        'hotbar
        SHotbar

        'Events
        SSpawnEvent
        SEventMove
        SEventDir
        SEventChat
        SEventStart
        SEventEnd
        SPlayBGM
        SPlaySound
        SFadeoutBGM
        SStopSound
        SSwitchesAndVariables
        SMapEventData
        SChatBubble
        SSpecialEffect
        SPic
        SHoldPlayer

        SProjectileEditor
        SUpdateProjectile
        SMapProjectile

        'recipes
        SUpdateRecipe
        SRecipeEditor
        SSendPlayerRecipe
        SOpenCraft
        SUpdateCraft

        'cards
        SSendCards
        SCardDeck
        SCardCollection
        STableData
        STableDeck
        SCardBattleStart
        SCardBattleEnd

        'Class Editor
        SClassEditor
        SUpdateClasses

        ' Make sure SMSG_COUNT is below everything else
        SMSG_COUNT
    End Enum

    ' Packets sent by client to server
    Public Enum ClientPackets
        CNewAccount = 1
        CDelAccount
        CLogin
        CAddChar
        CUseChar
        CDelChar
        CSayMsg
        CEmoteMsg
        CBroadcastMsg
        CPlayerMsg
        CPlayerMove
        CPlayerDir
        CUseItem
        CAttack
        CPlayerInfoRequest
        CWarpMeTo
        CWarpToMe
        CWarpTo
        CSetSprite
        CGetStats
        CRequestNewMap
        CMapData
        CNeedMap
        CMapGetItem
        CMapDropItem
        CMapRespawn
        CMapReport
        CKickPlayer
        CBanList
        CBanDestroy
        CBanPlayer
        CRequestEditMap
        CRequestEditItem
        CSaveItem
        CRequestEditNpc
        CSaveNpc
        CRequestEditShop
        CSaveShop
        CRequestEditSkill
        CSaveSkill
        CSetAccess
        CWhosOnline
        CSetMotd
        CSearch
        CParty
        CJoinParty
        CLeaveParty
        CSkills
        CCast
        CQuit
        CSwapInvSlots
        CRequestEditResource
        CSaveResource
        CCheckPing
        CUnequip
        CRequestPlayerData
        CRequestItems
        CRequestNPCS
        CRequestResources
        CSpawnItem
        CTrainStat
        CRequestEditAnimation
        CSaveAnimation
        CRequestAnimations
        CRequestSkills
        CRequestShops
        CRequestLevelUp
        CForgetSkill
        CCloseShop
        CBuyItem
        CSellItem
        CChangeBankSlots
        CDepositItem
        CWithdrawItem
        CCloseBank
        CAdminWarp

        CTradeInvite
        CTradeInviteAccept
        CAcceptTrade
        CDeclineTrade
        CTradeItem
        CUntradeItem

        CAdmin

        'quests
        CRequestEditQuest
        CSaveQuest
        CRequestQuests
        CQuestLogUpdate
        CPlayerHandleQuest
        CQuestReset

        'Housing
        CBuyHouse
        CVisit
        CAcceptVisit
        CPlaceFurniture
        CRequestEditHouse
        CSaveHouses
        CSellHouse

        'Hotbar
        CSetHotbarSkill
        CDeleteHotbarSkill

        'Events
        CEventChatReply
        CEvent
        CSwitchesAndVariables
        CRequestSwitchesAndVariables
        CEventTouch

        CRequestEditProjectiles
        CSaveProjectile
        CRequestProjectiles
        CClearProjectile

        'craft
        CRequestRecipes
        CRequestEditRecipes
        CSaveRecipe
        CCloseCraft
        CStartCraft

        'cards
        CRequestCardBattle
        CRequestCardBattleAwnser
        CCardPlacement
        CUpdateCardDeck

        'Class Editor
        CRequestClasses
        CRequestEditClasses
        CSaveClasses

        ' Make sure CMSG_COUNT is below everything else
        CMSG_COUNT
    End Enum
End Module
