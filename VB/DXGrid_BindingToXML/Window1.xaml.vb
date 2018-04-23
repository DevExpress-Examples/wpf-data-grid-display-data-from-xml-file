Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports System.Data

Namespace DXGrid_BindingToXML
	#Region "#1"
	Partial Public Class Window1
		Inherits Window
		Private Shared path As String = "..\..\Contacts.xml"
		Public Sub New()
			InitializeComponent()
			grid.DataSource = GetDataFromXML()
		End Sub
		Private Function GetDataFromXML() As DataTable
			Dim ds As New DataSet()
			ds.ReadXml(path)
			Return ds.Tables(0)
		End Function
		Private Sub PostDataToXML()
			CType(grid.DataSource, DataTable).DataSet.WriteXml(path)
		End Sub

		Private Sub Button_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			PostDataToXML()
			MessageBox.Show("Changes have been successfully saved to an XML file.", "Info")
		End Sub
	End Class
	#End Region ' #1
End Namespace
