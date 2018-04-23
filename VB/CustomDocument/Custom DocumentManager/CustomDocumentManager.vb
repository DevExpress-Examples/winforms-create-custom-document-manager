Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Linq
Imports DevExpress.XtraBars.Docking2010
Imports DevExpress.XtraBars.Docking2010.Views

Namespace CustomDocumentApplication
	<ToolboxItem(True)> _
	Public Class CustomDocumentManager
		Inherits DocumentManager
		Public Sub New()

		End Sub
		Public Sub New(ByVal container As IContainer)
			MyBase.New(container)

		End Sub

		Protected Overrides Sub RegisterViews()
			MyBase.RegisterViews()
			RegisterView(Of CustomWidgetViewRegistrator)(ViewType.Widget)
		End Sub

		Public Overrides Function CreateView(ByVal type As ViewType) As BaseView
            If type = ViewType.Widget Then
                Return New CustomWidgetView(Container)
            End If
			Return MyBase.CreateView(type)
		End Function
	End Class
End Namespace
