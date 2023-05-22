Imports System.ComponentModel


Partial Class MainMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                disposedComponents.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private formComponents As System.ComponentModel.IContainer
    Private disposedComponents As Object

    Public Class MainMenu
        Inherits Form

        Private formComponents As IContainer
        Public Event Load()

        Public Sub New()
            MyBase.New()
            Me.formComponents = components
            RaiseEvent Load()
        End Sub

        Private Sub Form_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' TODO: Add any initialization code here
        End Sub

        Friend Function components() As IContainer
            Throw New NotImplementedException()
        End Function
    End Class

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 24.0!)
        Me.Label1.Location = New System.Drawing.Point(71, 30)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(203, 45)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MAIN MENU"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(31, 83)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(115, 34)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Product Name"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(168, 83)
        Me.Button4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(115, 34)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Product ID"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(168, 124)
        Me.Button5.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(115, 33)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "Quantity"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(31, 122)
        Me.Button6.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(115, 36)
        Me.Button6.TabIndex = 6
        Me.Button6.Text = "Description"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(31, 177)
        Me.Button7.SetBounds(31, 177, 75, 23)

    End Sub

    Public Overrides Function Equals(obj As Object) As Boolean
        Dim menu = TryCast(obj, MainMenu)
        Return menu IsNot Nothing AndAlso
               EqualityComparer(Of IContainer).Default.Equals(Me.components, menu.components)
    End Function

    Public Overrides Function GetHashCode() As Integer
        Dim hashCode As Long = 469045609
        hashCode = (hashCode * -1521134295 + EqualityComparer(Of IContainer).Default.GetHashCode(Me.components)).GetHashCode()
        Return hashCode
    End Function
End Class
