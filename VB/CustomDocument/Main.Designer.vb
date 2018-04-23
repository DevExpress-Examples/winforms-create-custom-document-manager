Imports Microsoft.VisualBasic
Imports System
Namespace CustomDocumentApplication
	Partial Public Class Main
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.customDocumentManager1 = New CustomDocumentApplication.CustomDocumentManager(Me.components)
			Me.customWidgetView1 = New CustomDocumentApplication.CustomWidgetView(Me.components)
			Me.xtraUserControl3Document = New CustomDocumentApplication.CustomDocument(Me.components)
			Me.xtraUserControl2Document = New CustomDocumentApplication.CustomDocument(Me.components)
			Me.xtraUserControl1Document = New CustomDocumentApplication.CustomDocument(Me.components)
			Me.stackGroup1 = New DevExpress.XtraBars.Docking2010.Views.Widget.StackGroup(Me.components)
			CType(Me.customDocumentManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.customWidgetView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.xtraUserControl3Document, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.xtraUserControl2Document, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.xtraUserControl1Document, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.stackGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' customDocumentManager1
			' 
			Me.customDocumentManager1.ContainerControl = Me
			Me.customDocumentManager1.ShowThumbnailsInTaskBar = DevExpress.Utils.DefaultBoolean.False
			Me.customDocumentManager1.View = Me.customWidgetView1
			Me.customDocumentManager1.ViewCollection.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseView() { Me.customWidgetView1})
			' 
			' customWidgetView1
			' 
			Me.customWidgetView1.Documents.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseDocument() { Me.xtraUserControl3Document, Me.xtraUserControl2Document, Me.xtraUserControl1Document})
			Me.customWidgetView1.StackGroups.AddRange(New DevExpress.XtraBars.Docking2010.Views.Widget.StackGroup() { Me.stackGroup1})
			' 
			' xtraUserControl3Document
			' 
			Me.xtraUserControl3Document.Caption = "XtraUserControl3"
			Me.xtraUserControl3Document.ControlName = "XtraUserControl3"
			Me.xtraUserControl3Document.ControlTypeName = "CustomDocumentApplication.XtraUserControl3"
			Me.xtraUserControl3Document.CustomProperty = "Test3"
			' 
			' xtraUserControl2Document
			' 
			Me.xtraUserControl2Document.Caption = "XtraUserControl2"
			Me.xtraUserControl2Document.ControlName = "XtraUserControl2"
			Me.xtraUserControl2Document.ControlTypeName = "CustomDocumentApplication.XtraUserControl2"
			Me.xtraUserControl2Document.CustomProperty = "Test2"
			' 
			' xtraUserControl1Document
			' 
			Me.xtraUserControl1Document.Caption = "XtraUserControl1"
			Me.xtraUserControl1Document.ControlName = "XtraUserControl1"
			Me.xtraUserControl1Document.ControlTypeName = "CustomDocumentApplication.XtraUserControl1"
			Me.xtraUserControl1Document.CustomProperty = "Test1"
			' 
			' stackGroup1
			' 
			Me.stackGroup1.Items.AddRange(New DevExpress.XtraBars.Docking2010.Views.Widget.Document() { Me.xtraUserControl3Document, Me.xtraUserControl2Document, Me.xtraUserControl1Document})
			' 
			' Main
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(7F, 16F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(845, 610)
			Me.Name = "Main"
			Me.Text = "Form1"
			CType(Me.customDocumentManager1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.customWidgetView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.xtraUserControl3Document, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.xtraUserControl2Document, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.xtraUserControl1Document, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.stackGroup1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private customDocumentManager1 As CustomDocumentManager
		Private customWidgetView1 As CustomWidgetView
		Private xtraUserControl3Document As CustomDocument
		Private xtraUserControl2Document As CustomDocument
		Private xtraUserControl1Document As CustomDocument
		Private stackGroup1 As DevExpress.XtraBars.Docking2010.Views.Widget.StackGroup





	End Class
End Namespace

