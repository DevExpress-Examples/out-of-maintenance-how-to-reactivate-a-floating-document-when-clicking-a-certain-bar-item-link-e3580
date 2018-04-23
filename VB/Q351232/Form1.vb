Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports System.Collections.Generic
Imports DevExpress.XtraBars.Docking2010.Views

Namespace Q351232
	Partial Public Class Form1
		Inherits Form
		Private DocumentToRestore As BaseDocument

		Public Sub New()
			InitializeComponent()
			For i As Integer = 0 To 4
				Dim form As New Form()
				form.MdiParent = Me
				form.Text = String.Concat("Form ", i)
				form.Show()
			Next i
		End Sub

		Private Sub tabbedView1_DocumentDeactivated(ByVal sender As Object, ByVal e As DocumentEventArgs) Handles tabbedView1.DocumentDeactivated
			If e.Document.IsFloating AndAlso bar1.ItemLinks(0).ScreenBounds.Contains(MousePosition) Then
				DocumentToRestore = e.Document
			Else
				DocumentToRestore = Nothing
			End If
		End Sub

		Private Sub barButtonItem1_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barButtonItem1.ItemClick
			If DocumentToRestore IsNot Nothing Then
				tabbedView1.Controller.Activate(DocumentToRestore)
				DocumentToRestore = Nothing
			End If
			XtraMessageBox.Show(If(tabbedView1.ActiveFloatDocument Is Nothing, tabbedView1.ActiveDocument.Caption, tabbedView1.ActiveFloatDocument.Caption))
		End Sub
	End Class
End Namespace
