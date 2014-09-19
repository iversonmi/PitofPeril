<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PitofPeril
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblQuest = New System.Windows.Forms.Label()
        Me.lblcolor = New System.Windows.Forms.Label()
        Me.txtNameGuess = New System.Windows.Forms.TextBox()
        Me.txtQuestGuess = New System.Windows.Forms.TextBox()
        Me.txtColorGuess = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblQ1Answer = New System.Windows.Forms.Label()
        Me.lblQ2Answer = New System.Windows.Forms.Label()
        Me.lblQ3Answer = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(162, 223)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 0
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(58, 109)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(101, 13)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "What is your name?"
        '
        'lblQuest
        '
        Me.lblQuest.AutoSize = True
        Me.lblQuest.Location = New System.Drawing.Point(58, 139)
        Me.lblQuest.Name = "lblQuest"
        Me.lblQuest.Size = New System.Drawing.Size(101, 13)
        Me.lblQuest.TabIndex = 2
        Me.lblQuest.Text = "What is your quest?"
        '
        'lblcolor
        '
        Me.lblcolor.AutoSize = True
        Me.lblcolor.Location = New System.Drawing.Point(58, 174)
        Me.lblcolor.Name = "lblcolor"
        Me.lblcolor.Size = New System.Drawing.Size(136, 13)
        Me.lblcolor.TabIndex = 3
        Me.lblcolor.Text = "What is your favorite color?"
        '
        'txtNameGuess
        '
        Me.txtNameGuess.Location = New System.Drawing.Point(218, 102)
        Me.txtNameGuess.Name = "txtNameGuess"
        Me.txtNameGuess.Size = New System.Drawing.Size(123, 20)
        Me.txtNameGuess.TabIndex = 4
        '
        'txtQuestGuess
        '
        Me.txtQuestGuess.Location = New System.Drawing.Point(218, 136)
        Me.txtQuestGuess.Name = "txtQuestGuess"
        Me.txtQuestGuess.Size = New System.Drawing.Size(123, 20)
        Me.txtQuestGuess.TabIndex = 5
        '
        'txtColorGuess
        '
        Me.txtColorGuess.Location = New System.Drawing.Point(218, 171)
        Me.txtColorGuess.Name = "txtColorGuess"
        Me.txtColorGuess.Size = New System.Drawing.Size(123, 20)
        Me.txtColorGuess.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(284, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "You have come to the Bridge of Death!"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(70, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(236, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Answer me these 3 questions and you may pass."
        '
        'lblQ1Answer
        '
        Me.lblQ1Answer.AutoSize = True
        Me.lblQ1Answer.Location = New System.Drawing.Point(26, 311)
        Me.lblQ1Answer.Name = "lblQ1Answer"
        Me.lblQ1Answer.Size = New System.Drawing.Size(0, 13)
        Me.lblQ1Answer.TabIndex = 9
        '
        'lblQ2Answer
        '
        Me.lblQ2Answer.AutoSize = True
        Me.lblQ2Answer.Location = New System.Drawing.Point(26, 355)
        Me.lblQ2Answer.Name = "lblQ2Answer"
        Me.lblQ2Answer.Size = New System.Drawing.Size(0, 13)
        Me.lblQ2Answer.TabIndex = 10
        '
        'lblQ3Answer
        '
        Me.lblQ3Answer.AutoSize = True
        Me.lblQ3Answer.Location = New System.Drawing.Point(118, 355)
        Me.lblQ3Answer.Name = "lblQ3Answer"
        Me.lblQ3Answer.Size = New System.Drawing.Size(0, 13)
        Me.lblQ3Answer.TabIndex = 11
        '
        'PitofPeril
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(411, 386)
        Me.Controls.Add(Me.lblQ3Answer)
        Me.Controls.Add(Me.lblQ2Answer)
        Me.Controls.Add(Me.lblQ1Answer)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtColorGuess)
        Me.Controls.Add(Me.txtQuestGuess)
        Me.Controls.Add(Me.txtNameGuess)
        Me.Controls.Add(Me.lblcolor)
        Me.Controls.Add(Me.lblQuest)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnSubmit)
        Me.Name = "PitofPeril"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblQuest As System.Windows.Forms.Label
    Friend WithEvents lblcolor As System.Windows.Forms.Label
    Friend WithEvents txtNameGuess As System.Windows.Forms.TextBox
    Friend WithEvents txtQuestGuess As System.Windows.Forms.TextBox
    Friend WithEvents txtColorGuess As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblQ1Answer As System.Windows.Forms.Label
    Friend WithEvents lblQ2Answer As System.Windows.Forms.Label
    Friend WithEvents lblQ3Answer As System.Windows.Forms.Label

End Class
