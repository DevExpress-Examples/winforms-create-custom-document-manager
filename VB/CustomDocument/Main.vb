Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.XtraEditors

Namespace CustomDocumentApplication
	Partial Public Class Main
		Inherits XtraForm
		Public Sub New()
			InitializeComponent()
			' Handling the QueryControl event that will populate all automatically generated Documents
			AddHandler Me.customWidgetView1.QueryControl, AddressOf customWidgetView1_QueryControl
			AddHandler Me.customWidgetView1.DocumentActivated, AddressOf customWidgetView1_DocumentActivated
		End Sub

		Private Sub customWidgetView1_DocumentActivated(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Docking2010.Views.DocumentEventArgs)
			XtraMessageBox.Show((TryCast(e.Document, CustomDocument)).CustomProperty)
		End Sub

		' Assigning a required content for each auto generated Document
		Private Sub customWidgetView1_QueryControl(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Docking2010.Views.QueryControlEventArgs)

			If e.Document Is xtraUserControl3Document Then
				e.Control = New CustomDocumentApplication.XtraUserControl3()
			End If
			If e.Document Is xtraUserControl2Document Then
				e.Control = New CustomDocumentApplication.XtraUserControl2()
			End If
			If e.Document Is xtraUserControl1Document Then
				e.Control = New CustomDocumentApplication.XtraUserControl1()
			End If
			If e.Control Is Nothing Then
				e.Control = New System.Windows.Forms.Control()
			End If
		End Sub
	End Class
End Namespace