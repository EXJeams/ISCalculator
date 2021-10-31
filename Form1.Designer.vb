<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ISCalculator
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ISCalc = New System.Windows.Forms.Label()
        Me.labcount = New System.Windows.Forms.Label()
        Me.labresult = New System.Windows.Forms.Label()
        Me.labiterator = New System.Windows.Forms.Label()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.btnClean = New System.Windows.Forms.Button()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.tbResult = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ISCalc
        '
        Me.ISCalc.AllowDrop = True
        Me.ISCalc.AutoSize = True
        Me.ISCalc.Location = New System.Drawing.Point(380, 40)
        Me.ISCalc.Name = "ISCalc"
        Me.ISCalc.Size = New System.Drawing.Size(78, 13)
        Me.ISCalc.TabIndex = 0
        Me.ISCalc.Text = "CALCULATOR"
        '
        'labcount
        '
        Me.labcount.AutoSize = True
        Me.labcount.Location = New System.Drawing.Point(667, 129)
        Me.labcount.Name = "labcount"
        Me.labcount.Size = New System.Drawing.Size(44, 13)
        Me.labcount.TabIndex = 1
        Me.labcount.Text = "Counter"
        '
        'labresult
        '
        Me.labresult.AutoSize = True
        Me.labresult.Location = New System.Drawing.Point(191, 129)
        Me.labresult.Name = "labresult"
        Me.labresult.Size = New System.Drawing.Size(37, 13)
        Me.labresult.TabIndex = 2
        Me.labresult.Text = "Result"
        '
        'labiterator
        '
        Me.labiterator.AutoSize = True
        Me.labiterator.Location = New System.Drawing.Point(738, 129)
        Me.labiterator.Name = "labiterator"
        Me.labiterator.Size = New System.Drawing.Size(0, 13)
        Me.labiterator.TabIndex = 3
        '
        'btnInsert
        '
        Me.btnInsert.Location = New System.Drawing.Point(194, 206)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(75, 23)
        Me.btnInsert.TabIndex = 4
        Me.btnInsert.Text = "Insert Data"
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'btnClean
        '
        Me.btnClean.Location = New System.Drawing.Point(345, 206)
        Me.btnClean.Name = "btnClean"
        Me.btnClean.Size = New System.Drawing.Size(75, 23)
        Me.btnClean.TabIndex = 5
        Me.btnClean.Text = "Clean"
        Me.btnClean.UseVisualStyleBackColor = True
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(571, 124)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(75, 23)
        Me.btnShow.TabIndex = 6
        Me.btnShow.Text = "Show Data"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'tbResult
        '
        Me.tbResult.Location = New System.Drawing.Point(274, 126)
        Me.tbResult.Name = "tbResult"
        Me.tbResult.Size = New System.Drawing.Size(81, 20)
        Me.tbResult.TabIndex = 7
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.DataGridView1.Location = New System.Drawing.Point(507, 170)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(281, 150)
        Me.DataGridView1.TabIndex = 8
        '
        'Column1
        '
        Me.Column1.HeaderText = "N°"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 50
        '
        'Column2
        '
        Me.Column2.HeaderText = "Quantity"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Price"
        Me.Column3.Name = "Column3"
        '
        'ISCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.tbResult)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.btnClean)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.labiterator)
        Me.Controls.Add(Me.labresult)
        Me.Controls.Add(Me.labcount)
        Me.Controls.Add(Me.ISCalc)
        Me.Name = "ISCalculator"
        Me.Text = "IS"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ISCalc As Label
    Friend WithEvents labcount As Label
    Friend WithEvents labresult As Label
    Friend WithEvents labiterator As Label
    Friend WithEvents btnInsert As Button
    Friend WithEvents btnClean As Button
    Friend WithEvents btnShow As Button
    Friend WithEvents tbResult As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
End Class
