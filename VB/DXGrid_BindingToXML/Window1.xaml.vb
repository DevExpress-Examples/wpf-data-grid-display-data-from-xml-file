Imports System.Windows
Imports System.Windows.Controls
Imports System.Data

Namespace DXGrid_BindingToXML

'#Region "#1"
    Public Partial Class Window1
        Inherits Window

        Private Shared path As String = "..\..\Contacts.xml"

        Public Sub New()
            Me.InitializeComponent()
            Me.grid.ItemsSource = GetDataFromXML()
        End Sub

        Private Function GetDataFromXML() As DataTable
            Dim ds As DataSet = New DataSet()
            ds.ReadXml(path)
            Return ds.Tables(0)
        End Function

        Private Sub PostDataToXML()
            CType(Me.grid.ItemsSource, DataTable).DataSet.WriteXml(path)
        End Sub

        Private Sub Button_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            PostDataToXML()
            MessageBox.Show("Changes have been successfully saved to an XML file.", "Info")
        End Sub
    End Class
'#End Region  ' #1
End Namespace
