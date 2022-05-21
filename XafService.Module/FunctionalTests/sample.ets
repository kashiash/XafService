;#DropDB XafServiceEasyTest

#Application XafServiceWin
#Application XafServiceBlazor

*FillForm
 User Name = Admin
*Action Log In

#IfDef XafServiceWin

*Action About...
 
*Action OK

#EndIf

#IfDef XafServiceBlazor
*Action Navigation(My Details)
#EndIf
