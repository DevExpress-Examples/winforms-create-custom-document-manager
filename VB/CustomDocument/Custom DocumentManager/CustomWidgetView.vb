Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports DevExpress.Utils.Serializing
Imports DevExpress.XtraBars.Docking2010
Imports DevExpress.XtraBars.Docking2010.Views
Imports DevExpress.XtraBars.Docking2010.Views.Widget

Namespace CustomDocumentApplication
	Public Class CustomWidgetView
		Inherits WidgetView
		Public Sub New()

		End Sub
		Public Sub New(ByVal container As IContainer)
			MyBase.New(container)

		End Sub

		Friend Shadows ReadOnly Property IsSkinPaintStyle() As Boolean
			Get
				Return MyBase.IsSkinPaintStyle
			End Get
		End Property
	End Class
End Namespace
