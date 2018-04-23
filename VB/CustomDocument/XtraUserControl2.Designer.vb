Imports Microsoft.VisualBasic
Imports System
Namespace CustomDocumentApplication
	Partial Public Class XtraUserControl2
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

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.SuspendLayout()
			' 
			' XtraUserControl2
			' 
			Me.Appearance.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(128))))), (CInt(Fix((CByte(255))))), (CInt(Fix((CByte(128))))))
			Me.Appearance.Options.UseBackColor = True
			Me.AutoScaleDimensions = New System.Drawing.SizeF(7F, 16F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Name = "XtraUserControl2"
			Me.ResumeLayout(False)

		End Sub

		#End Region
	End Class
End Namespace
