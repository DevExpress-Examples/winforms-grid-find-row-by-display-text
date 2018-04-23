Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication1
	Partial Public Class GridViewSearch
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
			Dim serializableAppearanceObject1 As New DevExpress.Utils.SerializableAppearanceObject()
			Dim serializableAppearanceObject2 As New DevExpress.Utils.SerializableAppearanceObject()
			Me.panelControl3 = New DevExpress.XtraEditors.PanelControl()
			Me.btSearch = New DevExpress.XtraEditors.ButtonEdit()
			CType(Me.panelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl3.SuspendLayout()
			CType(Me.btSearch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' panelControl3
			' 
			Me.panelControl3.Controls.Add(Me.btSearch)
			Me.panelControl3.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelControl3.Location = New System.Drawing.Point(0, 0)
			Me.panelControl3.Name = "panelControl3"
			Me.panelControl3.Size = New System.Drawing.Size(347, 21)
			Me.panelControl3.TabIndex = 8
			' 
			' btSearch
			' 
			Me.btSearch.Dock = System.Windows.Forms.DockStyle.Fill
			Me.btSearch.Location = New System.Drawing.Point(2, 2)
			Me.btSearch.Name = "btSearch"
			Me.btSearch.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Prev", -1, True, True, True, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "Prev", Nothing, Nothing, True), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Next", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "Next", Nothing, Nothing, True)})
			Me.btSearch.Size = New System.Drawing.Size(343, 20)
			Me.btSearch.TabIndex = 2
'			Me.btSearch.ButtonClick += New DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(Me.buttonEdit1_ButtonClick);
'			Me.btSearch.TextChanged += New System.EventHandler(Me.btSearchChanged);
			' 
			' GridViewSearch
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.AutoSize = True
			Me.Controls.Add(Me.panelControl3)
			Me.Name = "GridViewSearch"
			Me.Size = New System.Drawing.Size(347, 24)
			CType(Me.panelControl3, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl3.ResumeLayout(False)
			CType(Me.btSearch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private panelControl3 As DevExpress.XtraEditors.PanelControl
		Private WithEvents btSearch As DevExpress.XtraEditors.ButtonEdit

	End Class
End Namespace
