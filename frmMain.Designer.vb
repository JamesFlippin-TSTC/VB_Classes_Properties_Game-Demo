<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblPlayerName = New System.Windows.Forms.Label()
        Me.lblTeamName = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblPlayerHealthPoints = New System.Windows.Forms.Label()
        Me.lblHorizontalLineLong = New System.Windows.Forms.Label()
        Me.tbxPlayerName = New System.Windows.Forms.TextBox()
        Me.tbxPlayerTeamName = New System.Windows.Forms.TextBox()
        Me.tbxPlayerHealthPoints = New System.Windows.Forms.TextBox()
        Me.lblHeroRemainingHP = New System.Windows.Forms.Label()
        Me.btnAttack = New System.Windows.Forms.Button()
        Me.tbxPlayerDamage = New System.Windows.Forms.TextBox()
        Me.lblPlayerDamage = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblMonsterTitle = New System.Windows.Forms.Label()
        Me.tbxMonsterDamage = New System.Windows.Forms.TextBox()
        Me.lblMonsterDamage = New System.Windows.Forms.Label()
        Me.tbxMonsterHealthPoints = New System.Windows.Forms.TextBox()
        Me.tbxMonsterType = New System.Windows.Forms.TextBox()
        Me.lblMonsterHealthPoints = New System.Windows.Forms.Label()
        Me.lblMonsterType = New System.Windows.Forms.Label()
        Me.lblVerticleLineLong = New System.Windows.Forms.Label()
        Me.lblMonsterRemainingHP = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblVerticleLineSmall = New System.Windows.Forms.Label()
        Me.btnBeginCombat = New System.Windows.Forms.Button()
        Me.lbxAttackResults = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(504, 547)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(106, 33)
        Me.btnExit.TabIndex = 25
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblPlayerName
        '
        Me.lblPlayerName.AutoSize = True
        Me.lblPlayerName.Location = New System.Drawing.Point(22, 51)
        Me.lblPlayerName.Name = "lblPlayerName"
        Me.lblPlayerName.Size = New System.Drawing.Size(101, 19)
        Me.lblPlayerName.TabIndex = 1
        Me.lblPlayerName.Text = "Player Name:"
        '
        'lblTeamName
        '
        Me.lblTeamName.AutoSize = True
        Me.lblTeamName.Location = New System.Drawing.Point(22, 83)
        Me.lblTeamName.Name = "lblTeamName"
        Me.lblTeamName.Size = New System.Drawing.Size(95, 19)
        Me.lblTeamName.TabIndex = 3
        Me.lblTeamName.Text = "Team Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 202)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(180, 19)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Health Points Remaining:"
        '
        'lblPlayerHealthPoints
        '
        Me.lblPlayerHealthPoints.AutoSize = True
        Me.lblPlayerHealthPoints.Location = New System.Drawing.Point(22, 112)
        Me.lblPlayerHealthPoints.Name = "lblPlayerHealthPoints"
        Me.lblPlayerHealthPoints.Size = New System.Drawing.Size(161, 19)
        Me.lblPlayerHealthPoints.TabIndex = 5
        Me.lblPlayerHealthPoints.Text = "Starting Health Points:"
        '
        'lblHorizontalLineLong
        '
        Me.lblHorizontalLineLong.BackColor = System.Drawing.Color.Black
        Me.lblHorizontalLineLong.ForeColor = System.Drawing.Color.Black
        Me.lblHorizontalLineLong.Location = New System.Drawing.Point(22, 186)
        Me.lblHorizontalLineLong.Name = "lblHorizontalLineLong"
        Me.lblHorizontalLineLong.Size = New System.Drawing.Size(588, 3)
        Me.lblHorizontalLineLong.TabIndex = 17
        Me.lblHorizontalLineLong.Text = " "
        '
        'tbxPlayerName
        '
        Me.tbxPlayerName.Location = New System.Drawing.Point(129, 48)
        Me.tbxPlayerName.Name = "tbxPlayerName"
        Me.tbxPlayerName.Size = New System.Drawing.Size(177, 26)
        Me.tbxPlayerName.TabIndex = 2
        '
        'tbxPlayerTeamName
        '
        Me.tbxPlayerTeamName.Location = New System.Drawing.Point(129, 80)
        Me.tbxPlayerTeamName.Name = "tbxPlayerTeamName"
        Me.tbxPlayerTeamName.Size = New System.Drawing.Size(177, 26)
        Me.tbxPlayerTeamName.TabIndex = 4
        '
        'tbxPlayerHealthPoints
        '
        Me.tbxPlayerHealthPoints.Location = New System.Drawing.Point(183, 109)
        Me.tbxPlayerHealthPoints.Name = "tbxPlayerHealthPoints"
        Me.tbxPlayerHealthPoints.Size = New System.Drawing.Size(123, 26)
        Me.tbxPlayerHealthPoints.TabIndex = 6
        '
        'lblHeroRemainingHP
        '
        Me.lblHeroRemainingHP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHeroRemainingHP.Location = New System.Drawing.Point(208, 202)
        Me.lblHeroRemainingHP.Name = "lblHeroRemainingHP"
        Me.lblHeroRemainingHP.Size = New System.Drawing.Size(98, 19)
        Me.lblHeroRemainingHP.TabIndex = 19
        '
        'btnAttack
        '
        Me.btnAttack.Enabled = False
        Me.btnAttack.Location = New System.Drawing.Point(265, 547)
        Me.btnAttack.Name = "btnAttack"
        Me.btnAttack.Size = New System.Drawing.Size(106, 33)
        Me.btnAttack.TabIndex = 24
        Me.btnAttack.Text = "&Attack"
        Me.btnAttack.UseVisualStyleBackColor = True
        '
        'tbxPlayerDamage
        '
        Me.tbxPlayerDamage.Location = New System.Drawing.Point(183, 141)
        Me.tbxPlayerDamage.Name = "tbxPlayerDamage"
        Me.tbxPlayerDamage.Size = New System.Drawing.Size(123, 26)
        Me.tbxPlayerDamage.TabIndex = 8
        '
        'lblPlayerDamage
        '
        Me.lblPlayerDamage.AutoSize = True
        Me.lblPlayerDamage.Location = New System.Drawing.Point(22, 144)
        Me.lblPlayerDamage.Name = "lblPlayerDamage"
        Me.lblPlayerDamage.Size = New System.Drawing.Size(147, 19)
        Me.lblPlayerDamage.TabIndex = 7
        Me.lblPlayerDamage.Text = "Damage Can Cause:"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(26, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(280, 27)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Hero"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMonsterTitle
        '
        Me.lblMonsterTitle.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonsterTitle.Location = New System.Drawing.Point(330, 21)
        Me.lblMonsterTitle.Name = "lblMonsterTitle"
        Me.lblMonsterTitle.Size = New System.Drawing.Size(280, 27)
        Me.lblMonsterTitle.TabIndex = 10
        Me.lblMonsterTitle.Text = "Monster"
        Me.lblMonsterTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbxMonsterDamage
        '
        Me.tbxMonsterDamage.Location = New System.Drawing.Point(487, 144)
        Me.tbxMonsterDamage.Name = "tbxMonsterDamage"
        Me.tbxMonsterDamage.Size = New System.Drawing.Size(123, 26)
        Me.tbxMonsterDamage.TabIndex = 16
        '
        'lblMonsterDamage
        '
        Me.lblMonsterDamage.AutoSize = True
        Me.lblMonsterDamage.Location = New System.Drawing.Point(326, 147)
        Me.lblMonsterDamage.Name = "lblMonsterDamage"
        Me.lblMonsterDamage.Size = New System.Drawing.Size(147, 19)
        Me.lblMonsterDamage.TabIndex = 15
        Me.lblMonsterDamage.Text = "Damage Can Cause:"
        '
        'tbxMonsterHealthPoints
        '
        Me.tbxMonsterHealthPoints.Location = New System.Drawing.Point(487, 112)
        Me.tbxMonsterHealthPoints.Name = "tbxMonsterHealthPoints"
        Me.tbxMonsterHealthPoints.Size = New System.Drawing.Size(123, 26)
        Me.tbxMonsterHealthPoints.TabIndex = 14
        '
        'tbxMonsterType
        '
        Me.tbxMonsterType.Location = New System.Drawing.Point(448, 51)
        Me.tbxMonsterType.Name = "tbxMonsterType"
        Me.tbxMonsterType.Size = New System.Drawing.Size(162, 26)
        Me.tbxMonsterType.TabIndex = 12
        '
        'lblMonsterHealthPoints
        '
        Me.lblMonsterHealthPoints.AutoSize = True
        Me.lblMonsterHealthPoints.Location = New System.Drawing.Point(326, 115)
        Me.lblMonsterHealthPoints.Name = "lblMonsterHealthPoints"
        Me.lblMonsterHealthPoints.Size = New System.Drawing.Size(161, 19)
        Me.lblMonsterHealthPoints.TabIndex = 13
        Me.lblMonsterHealthPoints.Text = "Starting Health Points:"
        '
        'lblMonsterType
        '
        Me.lblMonsterType.AutoSize = True
        Me.lblMonsterType.Location = New System.Drawing.Point(326, 54)
        Me.lblMonsterType.Name = "lblMonsterType"
        Me.lblMonsterType.Size = New System.Drawing.Size(109, 19)
        Me.lblMonsterType.TabIndex = 11
        Me.lblMonsterType.Text = "Monster Type:"
        '
        'lblVerticleLineLong
        '
        Me.lblVerticleLineLong.BackColor = System.Drawing.Color.Black
        Me.lblVerticleLineLong.ForeColor = System.Drawing.Color.Black
        Me.lblVerticleLineLong.Location = New System.Drawing.Point(317, 48)
        Me.lblVerticleLineLong.Name = "lblVerticleLineLong"
        Me.lblVerticleLineLong.Size = New System.Drawing.Size(3, 120)
        Me.lblVerticleLineLong.TabIndex = 9
        Me.lblVerticleLineLong.Text = " "
        '
        'lblMonsterRemainingHP
        '
        Me.lblMonsterRemainingHP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMonsterRemainingHP.Location = New System.Drawing.Point(512, 202)
        Me.lblMonsterRemainingHP.Name = "lblMonsterRemainingHP"
        Me.lblMonsterRemainingHP.Size = New System.Drawing.Size(98, 19)
        Me.lblMonsterRemainingHP.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(326, 202)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(180, 19)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Health Points Remaining:"
        '
        'lblVerticleLineSmall
        '
        Me.lblVerticleLineSmall.BackColor = System.Drawing.Color.Black
        Me.lblVerticleLineSmall.ForeColor = System.Drawing.Color.Black
        Me.lblVerticleLineSmall.Location = New System.Drawing.Point(317, 199)
        Me.lblVerticleLineSmall.Name = "lblVerticleLineSmall"
        Me.lblVerticleLineSmall.Size = New System.Drawing.Size(3, 20)
        Me.lblVerticleLineSmall.TabIndex = 20
        Me.lblVerticleLineSmall.Text = " "
        '
        'btnBeginCombat
        '
        Me.btnBeginCombat.Location = New System.Drawing.Point(26, 547)
        Me.btnBeginCombat.Name = "btnBeginCombat"
        Me.btnBeginCombat.Size = New System.Drawing.Size(106, 33)
        Me.btnBeginCombat.TabIndex = 23
        Me.btnBeginCombat.Text = "&Begin"
        Me.btnBeginCombat.UseVisualStyleBackColor = True
        '
        'lbxAttackResults
        '
        Me.lbxAttackResults.FormattingEnabled = True
        Me.lbxAttackResults.ItemHeight = 19
        Me.lbxAttackResults.Location = New System.Drawing.Point(26, 224)
        Me.lbxAttackResults.Name = "lbxAttackResults"
        Me.lbxAttackResults.Size = New System.Drawing.Size(584, 308)
        Me.lbxAttackResults.TabIndex = 26
        '
        'frmMain
        '
        Me.AcceptButton = Me.btnBeginCombat
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(635, 608)
        Me.Controls.Add(Me.lbxAttackResults)
        Me.Controls.Add(Me.btnBeginCombat)
        Me.Controls.Add(Me.lblVerticleLineSmall)
        Me.Controls.Add(Me.lblMonsterRemainingHP)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblVerticleLineLong)
        Me.Controls.Add(Me.lblMonsterTitle)
        Me.Controls.Add(Me.tbxMonsterDamage)
        Me.Controls.Add(Me.lblMonsterDamage)
        Me.Controls.Add(Me.tbxMonsterHealthPoints)
        Me.Controls.Add(Me.tbxMonsterType)
        Me.Controls.Add(Me.lblMonsterHealthPoints)
        Me.Controls.Add(Me.lblMonsterType)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tbxPlayerDamage)
        Me.Controls.Add(Me.lblPlayerDamage)
        Me.Controls.Add(Me.btnAttack)
        Me.Controls.Add(Me.lblHeroRemainingHP)
        Me.Controls.Add(Me.tbxPlayerHealthPoints)
        Me.Controls.Add(Me.tbxPlayerTeamName)
        Me.Controls.Add(Me.tbxPlayerName)
        Me.Controls.Add(Me.lblHorizontalLineLong)
        Me.Controls.Add(Me.lblPlayerHealthPoints)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblTeamName)
        Me.Controls.Add(Me.lblPlayerName)
        Me.Controls.Add(Me.btnExit)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "2020.07"
        Me.Text = "Demonstration - Class Properties  and Setters /Getters"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents lblPlayerName As Label
    Friend WithEvents lblTeamName As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblPlayerHealthPoints As Label
    Friend WithEvents lblHorizontalLineLong As Label
    Friend WithEvents tbxPlayerName As TextBox
    Friend WithEvents tbxPlayerTeamName As TextBox
    Friend WithEvents tbxPlayerHealthPoints As TextBox
    Friend WithEvents lblHeroRemainingHP As Label
    Friend WithEvents btnAttack As Button
    Friend WithEvents tbxPlayerDamage As TextBox
    Friend WithEvents lblPlayerDamage As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblMonsterTitle As Label
    Friend WithEvents tbxMonsterDamage As TextBox
    Friend WithEvents lblMonsterDamage As Label
    Friend WithEvents tbxMonsterHealthPoints As TextBox
    Friend WithEvents tbxMonsterType As TextBox
    Friend WithEvents lblMonsterHealthPoints As Label
    Friend WithEvents lblMonsterType As Label
    Friend WithEvents lblVerticleLineLong As Label
    Friend WithEvents lblMonsterRemainingHP As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblVerticleLineSmall As Label
    Friend WithEvents btnBeginCombat As Button
    Friend WithEvents lbxAttackResults As ListBox
End Class
