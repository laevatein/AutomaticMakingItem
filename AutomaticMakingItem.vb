# AutomaticMakingItem
for FFBE

// When World on the center, Enter Manufactutre Page

//If CmpColorEx("607|873|293313", 0.9) = 1 Then 
//Tap 607, 873
//Delay 3000
//End If
Dim Flag
Dim ClickDelay = 2000
Dim MaxTimer = 10

Dim TotalEquipment, TotalAbility, TotalProps
TotalEquipment = 4
TotalAbility = 3
TotalProps = 2

Dim StatusEmpty, StatusFinished, ItemSelected, ItemUnselected
StatusEmpty = "595915"
StatusFinished = "175267"
ItemSelected = "CEA600"
ItemUnselected = "3B2724"

Dim ItemEquipmentPX, ItemEquipmentPY, ItemAbilityPX, ItemAbilityPY, ItemPropsPX, ItemPropsPY
ItemEquipmentPX = 215
ItemEquipmentPY = 380

ItemAbilityPX = 454
ItemAbilityPY = 380

ItemPropsPX = 692
ItemPropsPY = 380


//First Item
Dim MoguriOfFirstItemPX, MoguriOfFirstItemPY, StatusOfFirstItemPX, StatusOfFirstItemPY
StatusOfFirstItemPX = 586
StatusOfFirstItemPY = 472
MoguriOfFirstItemPX = 470
MoguriOfFirstItemPY = 530

// Second Item
Dim MoguriOfSecondItemPX, MoguriOfSecondItemPY,StatusOfSecondItemPX, StatusOfSecondItemPY
StatusOfSecondItemPX = 586
StatusOfSecondItemPY = 652
MoguriOfSecondItemPX = 470
MoguriOfSecondItemPY = 710

// Third Item
Dim MoguriOfThirdItemPX, MoguriOfThirdItemPY,StatusOfThirdItemPX, StatusOfThirdItemPY
StatusOfThirdItemPX = 586
StatusOfThirdItemPY = 832
MoguriOfThirdItemPX = 470
MoguriOfThirdItemPY = 890

// Fourth Item
Dim MoguriOfFourthItemPX, MoguriOfFourthItemPY,StatusOfFourthItemPX, StatusOfFourthItemPY
StatusOfFourthItemPX = 586
StatusOfFourthItemPY = 1012
MoguriOfFourthItemPX = 470
MoguriOfFourthItemPY = 1070

Dim YESpX = 534, YESpY = 712, OKpX = 361, OKpY = 878

Dim NowItemNumber 
Dim TotalNumber
Dim Count

////////////////////////////////////////////
TracePrint "Start"

//Call MakingAll()
Call MakingPotion()

TracePrint "End"
////////////////////////////////////////////

///////////////////
//ShiningCrystalShow()
///////////////////
Function ShiningCrystalShow()
If CmpColorEx("139|699|343E1C", 0.9) = 1 And CmpColorEx("111|736|AFCA5E", 0.9) = 1 Then 
 Tap 361,878
End If
End Function


///////////////////
//MakingAbility()
///////////////////

Function MakingAbility()

Dim Timer = 40 // becus your light crystal only this number
// Props
Call ChangePage(2)
Delay 1500

//Call Wait Page Changed

TotalNumber = TotalAbility

For Count = 1 To Timer Step 1
TracePrint "Start make props"

For NowItemNumber = 1 To TotalNumber Step 1
MakeAbility(NowItemNumber)
Delay 4000
Next

Delay 300000

TracePrint "Collecting ability"

For NowItemNumber = 1 To TotalNumber Step 1
WhenFinshed (NowItemNumber)
ShiningCrystalShow()
Delay 3000
Next

Next
End Function


///////////////////
//MakingPotion()
///////////////////

Function MakingPotion()

Dim Timer = 60 // becus your water crystal only this number
// Props
Call ChangePage(3)
Delay 1000

TotalNumber = TotalProps

For Count = 1 To Timer Step 1
TracePrint "Start make props"

For NowItemNumber = 1 To TotalNumber Step 1
MakeCurePotion(NowItemNumber)
Delay 3000
Next

Delay 60000

TracePrint "Collecting props"

For NowItemNumber = 1 To TotalNumber Step 1
WhenFinshed(NowItemNumber)
Delay 3000
Next

Next
End Function

///////////////////
//MakingAll()
///////////////////

Function MakingAll()
TracePrint "MakingAll Start"

Do

TracePrint "Change to Equipment page"
Call ChangePage(1)
Delay 1000

TracePrint "Start make equipment"

TotalNumber = TotalEquipment
For NowItemNumber = 2 To TotalNumber Step 1
MakeCurePotion(NowItemNumber)
Delay 3000
Next

TracePrint "Change to Ability page"
Call ChangePage(2)
Delay 1000

TracePrint "Start make ability"

TotalNumber = TotalAbility
For NowItemNumber = 1 To TotalNumber Step 1
MakeAbility(NowItemNumber)
Delay 3000
Next

TracePrint "Changeto Props page"

// Props
Call ChangePage(3)
Delay 1000

TotalNumber = TotalProps

For Count = 1 To 5 Step 1
TracePrint "Start make props"

For NowItemNumber = 1 To TotalNumber Step 1
MakeCurePotion(NowItemNumber)
Delay 4000
Next

Delay 60000

TracePrint "Collecting props"

For NowItemNumber = 1 To TotalNumber Step 1
WhenFinshed(NowItemNumber)
Delay 3000
Next

Next

TracePrint "Finish collecting props and go to ability page"

Call ChangePage(2)
Delay 1000
TotalNumber = TotalAbility
For NowItemNumber = 1 To TotalNumber Step 1
WhenFinshed (NowItemNumber)
ShiningCrystalShow()
Delay 3000
Next

TracePrint "Finish collecting ability and go to equipment page"

Call ChangePage(1)
Delay 1000
TotalNumber = TotalEquipment
For NowItemNumber = 2 To TotalNumber Step 1
WhenFinshed(NowItemNumber)
Delay 3000
Next

TracePrint "loop again"
Loop
End Function


///////////////////
//ChangePage
///////////////////

Function ChangePage(Page)
If Page = 1 Then 
 Tap ItemEquipmentPX, ItemEquipmentPY
ElseIf Page = 2 Then
 Tap ItemAbilityPX, ItemAbilityPY
ElseIf Page = 3 Then
 Tap ItemPropsPX, ItemPropsPY
End If
End Function

Function MakeWhip(ItemNumber) // same with make cure potion
 Call MakeCurePotion(ItemNumber)
End Function


///////////////////
//MakeCurePotion
///////////////////

Function MakeCurePotion(ItemNumber)
Dim ItemStatusPX, ItemStatusPY, ItemMoguriPX, ItemMoguriPY
Dim Result
Dim Ret
Dim Timer

If ItemNumber = 1 Then 
 ItemStatusPX = StatusOfFirstItemPX
 ItemStatusPY = StatusOfFirstItemPY
 ItemMoguriPX = MoguriOfFirstItemPX
 ItemMoguriPY = MoguriOfFirstItemPY

ElseIf ItemNumber = 2 Then
 ItemStatusPX = StatusOfSecondItemPX
 ItemStatusPY = StatusOfSecondItemPY
 ItemMoguriPX = MoguriOfSecondItemPX
 ItemMoguriPY = MoguriOfSecondItemPY
 
ElseIf ItemNumber = 3 Then
 ItemStatusPX = StatusOfThirdItemPX
 ItemStatusPY = StatusOfThirdItemPY
 ItemMoguriPX = MoguriOfThirdItemPX
 ItemMoguriPY = MoguriOfThirdItemPY
 
ElseIf ItemNumber = 4 Then
 ItemStatusPX = StatusOfFourthItemPX
 ItemStatusPY = StatusOfFourthItemPY
 ItemMoguriPX = MoguriOfFourthItemPX
 ItemMoguriPY = MoguriOfFourthItemPY
End If
// Item Page
// First Item and it is empty
Result = ItemStatusPX & "|" & ItemStatusPY & "|" & StatusEmpty

TracePrint "(MakeCurePotion)Click Item"
Ret = CmpColorEx(Result, 0.9)
If Ret = 0 Then 
 Exit Function
Else 

Timer = 0
Tap ItemMoguriPX, ItemMoguriPY
Delay ClickDelay // wait items page show

Do
Ret = CmpColorEx("66|529|895502", 0.9)
If Ret = 0 Then 
Timer = Timer + 1
Else 
Exit Do
End If
Delay 500
Loop While Timer < MaxTimer

If Timer >= MaxTimer Then 
 TracePrint "(MakeCurePotion)Exit"
 Exit Function
End If

//TracePrint "(MakeCurePotion)Click Cure Page"
//Do
//Ret = CmpColorEx("40|381|E15C1A", 0.9)
//If Ret = 0 Then 
//Tap 82, 379
//Delay 1000
//End If
//Loop Until Ret = 1

TracePrint "(MakeCurePotion)Click Curepotion"
Timer = 0

Tap 404,533 
Delay ClickDelay
End If

Do
Ret = CmpColorEx("480|974|FFFFFF", 0.9)
If Ret = 0 Then 
Timer = Timer + 1
Else 
Exit Do
End If
Delay 500
Loop While Timer < MaxTimer

If Timer >= MaxTimer Then 
 TracePrint "(MakeCurePotion)Exit"
 Exit Function
End If

TracePrint "(MakeCurePotion)Click Make It"
Timer = 0

Tap 480,974
Delay ClickDelay

Do
Ret = CmpColorEx("503|712|FFFFFF", 0.9)
If Ret = 0 Then 
Timer = Timer + 1
Else 
Exit Do
End If
Delay 500
Loop While Timer < MaxTimer

If Timer >= MaxTimer Then 
 TracePrint "(MakeCurePotion)Exit"
 Exit Function
End If

TracePrint "(MakeCurePotion)Click Yes"
Timer = 0 

Tap 503,712
Delay ClickDelay

Do
Ret = CmpColorEx("565|463|00005F", 0.9) // Making status
If Ret = 0 Then 
Timer = Timer + 1
Else 
Exit Do
End If
Delay 500
Loop While Timer < MaxTimer

If Timer >= MaxTimer Then 
 TracePrint "(MakeCurePotion)Exit"
 Exit Function
End If

TracePrint "(MakeCurePotion)Success"

End Function

///////////////////
//MakeAbility
///////////////////

Function MakeAbility(ItemNumber)
Dim ItemStatusPX, ItemStatusPY, ItemMoguriPX, ItemMoguriPY
Dim Result
Dim Ret

If ItemNumber = 1 Then 
 ItemStatusPX = StatusOfFirstItemPX
 ItemStatusPY = StatusOfFirstItemPY
 ItemMoguriPX = MoguriOfFirstItemPX
 ItemMoguriPY = MoguriOfFirstItemPY

ElseIf ItemNumber = 2 Then
 ItemStatusPX = StatusOfSecondItemPX
 ItemStatusPY = StatusOfSecondItemPY
 ItemMoguriPX = MoguriOfSecondItemPX
 ItemMoguriPY = MoguriOfSecondItemPY
 
ElseIf ItemNumber = 3 Then
 ItemStatusPX = StatusOfThirdItemPX
 ItemStatusPY = StatusOfThirdItemPY
 ItemMoguriPX = MoguriOfThirdItemPX
 ItemMoguriPY = MoguriOfThirdItemPY
 
ElseIf ItemNumber = 4 Then
 ItemStatusPX = StatusOfFourthItemPX
 ItemStatusPY = StatusOfFourthItemPY
 ItemMoguriPX = MoguriOfFourthItemPX
 ItemMoguriPY = MoguriOfFourthItemPY
End If
// Item Page
// First Item and it is empty
Result = ItemStatusPX & "|" & ItemStatusPY & "|" & StatusEmpty

Ret = CmpColorEx(Result, 0.9)
If Ret = 1 Then 
Tap ItemMoguriPX, ItemMoguriPY
Delay 2000 // wait items page show
Else 
Exit Function
End If

// click white mage page
Do
Ret = CmpColorEx("205|380|2E2E34", 0.9)
If Ret = 1 Then 
Tap 205,380 
End If
Loop Until Ret = 1
Delay 3000

// click Curepotion
Tap 404,533 
Delay 1000

// click make it
If CmpColorEx("480|974|646464", 0.8) = 1 Then // make button is block
 Exit Function
End If
Tap 509,970 
Delay 1000

// click yes
Tap 534,712 
Delay 1000
End Function

///////////////////
//WhenFinshed
///////////////////

Function WhenFinshed(ItemNumber)
Dim ItemStatusPX, ItemStatusPY, ItemMoguriPX, ItemMoguriPY
Dim Result
Dim Timer
Dim Ret

If ItemNumber = 1 Then 
 ItemStatusPX = StatusOfFirstItemPX
 ItemStatusPY = StatusOfFirstItemPY
 ItemMoguriPX = MoguriOfFirstItemPX
 ItemMoguriPY = MoguriOfFirstItemPY
 
ElseIf ItemNumber = 2 Then
 ItemStatusPX = StatusOfSecondItemPX
 ItemStatusPY = StatusOfSecondItemPY
 ItemMoguriPX = MoguriOfSecondItemPX
 ItemMoguriPY = MoguriOfSecondItemPY
 
ElseIf ItemNumber = 3 Then
 ItemStatusPX = StatusOfThirdItemPX
 ItemStatusPY = StatusOfThirdItemPY
 ItemMoguriPX = MoguriOfThirdItemPX
 ItemMoguriPY = MoguriOfThirdItemPY
 
ElseIf ItemNumber = 4 Then
 ItemStatusPX = StatusOfFourthItemPX
 ItemStatusPY = StatusOfFourthItemPY
 ItemMoguriPX = MoguriOfFourthItemPX
 ItemMoguriPY = MoguriOfFourthItemPY
End If

// Check #item status is finished
Result = ItemStatusPX & "|" & ItemStatusPY & "|" & StatusFinished

// when status show finished
Timer = 0
Do
Ret = CmpColorEx(Result, 0.9)
If Ret = 0 Then 
Timer = Timer + 1
Else 
Exit Do
End If
Delay 500
Loop While Timer < MaxTimer

If Timer >= MaxTimer Then 
 TracePrint "(WhenFinshed)Exit"
 Exit Function
End If

Tap ItemMoguriPX, ItemMoguriPY
Delay ClickDelay
WaitConnecting()

Timer = 0
Do
Ret = CmpColorEx("355|872|FFFFFF", 0.9)
If Ret = 1 Then 
Exit Do
Else 
Timer = Timer + 1
End If
Delay 500
Loop While Timer < MaxTimer

If Timer >= MaxTimer Then 
 TracePrint "(WhenFinshed)Exit"
 Exit Function
End If

Tap 355, 872
Delay 100
Tap 355, 872

TracePrint "(WhenFinshed)Success"

End Function

Function WaitConnecting
Dim Ret
Dim Timer
TracePrint "(WaitConnecting)Start"

Timer = 0
Do
Ret = CmpColorEx("500|672|FFFFFF", 0.9)
If Ret = 1 Then 
Timer = Timer + 1
Else 
Exit Do
End If
Loop While Timer < MaxTimer

If Timer >= MaxTimer Then 
 TracePrint "(WhenFinshed)Exit"
 Exit Function
End If

TracePrint "(WaitConnecting)Success"
End Function
