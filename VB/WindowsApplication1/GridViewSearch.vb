Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid

Namespace WindowsApplication1

    Public Partial Class GridViewSearch
        Inherits UserControl

        Public Sub New()
            InitializeComponent()
        End Sub

        Private _SearchColumn As GridColumn

        Public Property SearchColumn As GridColumn
            Get
                Return _SearchColumn
            End Get

            Set(ByVal value As GridColumn)
                _SearchColumn = value
            End Set
        End Property

        Private _SearchText As String

        Public Property SearchText As String
            Get
                Return _SearchText
            End Get

            Set(ByVal value As String)
                _SearchText = value
                OnSearchTextChanged()
            End Set
        End Property

        Private Sub OnSearchTextChanged()
            btSearch.Text = _SearchText
        End Sub

        Private Function GetSearchGridView() As GridView
            Return TryCast(SearchColumn.View, GridView)
        End Function

        Private Function FindRow(ByVal startRowHandle As Integer, ByVal isForward As Boolean) As Integer
            If SearchColumn Is Nothing Then Return GridControl.InvalidRowHandle
            startRowHandle = Math.Max(0, startRowHandle)
            Dim view As GridView = GetSearchGridView()
            Try
                Dim delta As Integer = If(isForward, 1, -1)
                Dim n As Integer = startRowHandle
                While view.IsValidRowHandle(n)
                    n += delta
                    Dim cellText As String = GetSearchGridView().GetRowCellDisplayText(n, SearchColumn)
                    If cellText.Contains(SearchText) Then Return n
                End While
            Catch
            End Try

            Return GridControl.InvalidRowHandle
        End Function

        Private Sub FocusNextRow(ByVal isForward As Boolean)
            Dim searchGridView As GridView = GetSearchGridView()
            Dim focusedRowHandle As Integer = FindRow(searchGridView.FocusedRowHandle, isForward)
            searchGridView.FocusedRowHandle = focusedRowHandle
        End Sub

        Private Sub buttonEdit1_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs)
            FocusNextRow(Not e.Button.IsLeft)
        End Sub

        Private Sub btSearchChanged(ByVal sender As Object, ByVal e As EventArgs)
            SearchText = btSearch.Text
        End Sub
    End Class
End Namespace
