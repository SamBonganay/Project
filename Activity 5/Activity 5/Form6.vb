﻿Imports System.ComponentModel


Partial Class Form6
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Sub Dispose(ByVal disposing As Boolean, ByVal components As Object)

        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private ReadOnly myComponents As IContainer

    Public Sub New(components As IContainer)
        myComponents = components
    End Sub

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(270, 57)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(480, 305)
        Me.DataGridView1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(93, 102)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(137, 42)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Upload CSV"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(93, 180)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(137, 35)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Main Menu"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form7"
        Me.Text = "Form7"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Public Overrides Function Equals(obj As Object) As Boolean
        Dim form = TryCast(obj, Form6)
        Return form IsNot Nothing AndAlso
               EqualityComparer(Of IContainer).Default.Equals(Me.components, form.components)
    End Function

    Public Overrides Function GetHashCode() As Integer
        Dim hashCode As Long = 469045609
        hashCode = (hashCode * -1521134295 + EqualityComparer(Of IContainer).Default.GetHashCode(Me.components)).GetHashCode()
        Return hashCode
    End Function

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
