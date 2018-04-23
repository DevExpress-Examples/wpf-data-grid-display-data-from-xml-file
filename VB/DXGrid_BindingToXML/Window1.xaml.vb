Imports System.Windows
Imports System.Data

Namespace DXGrid_BindingToXML

    Partial Public Class Window1
        Inherits Window

        Private Shared path As String = "..\..\Contacts.xml"
        Public Sub New()
            InitializeComponent()
            grid.ItemsSource = GetDataFromXML()
        End Sub
        Private Function GetDataFromXML() As DataTable
            Dim ds As New DataSet()
            ds.ReadXml(path)
            Return ds.Tables(0)
        End Function
        Private Sub PostDataToXML()
            CType(grid.ItemsSource, DataTable).DataSet.WriteXml(path)
        End Sub

        Private Sub Button_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            PostDataToXML()
            MessageBox.Show("Changes have been successfully saved to an XML file.", "Info")
        End Sub
    End Class

End Namespace
