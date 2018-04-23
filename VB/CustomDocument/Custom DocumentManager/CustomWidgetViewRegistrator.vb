Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.XtraBars.Docking2010
Imports DevExpress.XtraBars.Docking2010.Views
Imports DevExpress.XtraBars.Docking2010.Views.Widget

Namespace CustomDocumentApplication
	Friend Class CustomWidgetViewRegistrator
		Inherits BaseRegistrator
		Public Sub New()
			MyBase.New(Nothing)
		End Sub
		Public Sub New(ByVal view As WidgetView)
			MyBase.New(view)
		End Sub
		Public Overrides Function CreatePainter() As BaseViewPainter
			If View.IsSkinPaintStyle Then
				Return New WidgetViewSkinPainter(TryCast(View, WidgetView))
			End If
			Return New WidgetViewPainter(TryCast(View, WidgetView))
		End Function
		Public Overrides Function CreateViewInfo() As BaseViewInfo
			Return New WidgetViewInfo(TryCast(View, WidgetView))
		End Function
		Public Overrides Function CreateHitInfo() As BaseViewHitInfo
			Return New WidgetViewHitInfo(TryCast(View, WidgetView))
		End Function
		Public Overrides Function CreateDocument(ByVal control As Control) As BaseDocument
			Return New CustomDocument(TryCast(View.DocumentProperties, IDocumentProperties))
		End Function
		Protected Overrides Function Register() As Create
			Return Function(view As BaseView) New CustomWidgetViewRegistrator(TryCast(view, WidgetView))
		End Function
		Public Overrides Function CreateDocumentContainer(ByVal document As BaseDocument) As DocumentContainer
			Return New WidgetContainer(document)
		End Function
		Public Overrides Function CreateDocumentsHost(ByVal owner As IDocumentsHostOwner) As Control
			Return New WidgetsHost(owner)
		End Function

		Private Shadows ReadOnly Property View() As CustomWidgetView
			Get
				Return TryCast(MyBase.View, CustomWidgetView)
			End Get
		End Property
	End Class
End Namespace
