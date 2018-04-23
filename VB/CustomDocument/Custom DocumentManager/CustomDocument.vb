Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Linq
Imports DevExpress.Utils.Serializing
Imports DevExpress.XtraBars.Docking2010.Views.Widget

Namespace CustomDocumentApplication
	Public Class CustomDocument
		Inherits Document
		Public Sub New()

		End Sub
		Public Sub New(ByVal container As IContainer)
			MyBase.New(container)

		End Sub
		Public Sub New(ByVal defaultProperties As IDocumentProperties)
			MyBase.New(defaultProperties)

		End Sub

		Private customValue As String
		<XtraSerializableProperty> _
		Public Property CustomProperty() As String
			Get
				Return customValue
			End Get
			Set(ByVal value As String)
				customValue = value
			End Set
		End Property
	End Class
End Namespace
