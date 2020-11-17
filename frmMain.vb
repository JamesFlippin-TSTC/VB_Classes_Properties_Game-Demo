'*******************************************
'*******************************************
'Programmer: James Flippin
'Course: ITSE 1332.10x1 (VB)
'Program purpose: Demonstration code using a
'                 Class file, Properties,
'                 Setters And Getters
'*******************************************
'*******************************************

#Region "Compiler_Directives"

'*******************************************
Option Explicit On  'Forces explicit declaration of all variables in a file, or allows implicit declarations of variables
Option Strict On    'Restricts implicit data type conversions to only widening conversions, disallows late binding, and disallows implicit typing
Option Infer Off    'Disables the use of local type inference in declaring variables
#Disable Warning IDE1006    'Disables warnings over class naming convention for controls
'*******************************************

#End Region

Public Class frmMain
    Dim clsHero As New clsPlayer
    Dim clsMonster As New clsPlayer

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Exits the Application
        Application.Exit()
    End Sub

    Private Sub btnBeginCombat_Click(sender As Object, e As EventArgs) Handles btnBeginCombat.Click

        'Set the Hero Class Object Properties
        If Not tbxPlayerName.Text.Trim.Length > 0 Then
            MessageBox.Show("Missing or blank Player Name",
                "Validation Failure - Player Name", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbxPlayerName.Focus()
            tbxPlayerName.SelectAll()
            Return
        End If
        clsHero.strName = tbxPlayerName.Text.Trim

        If Not tbxPlayerTeamName.Text.Trim.Length > 0 Then
            MessageBox.Show("Missing or blank Player Team Name",
                "Validation Failure - Player Team Name", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbxPlayerTeamName.Focus()
            tbxPlayerTeamName.SelectAll()
            Return
        End If
        clsHero.strTeam = tbxPlayerTeamName.Text.Trim

        If Not Integer.TryParse(tbxPlayerHealthPoints.Text, clsHero.intHeathPoints) Then
            MessageBox.Show("Invalid or non-Integer Entry",
                "Validation Failure - Player Health", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbxPlayerHealthPoints.Focus()
            tbxPlayerHealthPoints.SelectAll()
            Return
        End If

        If Not Integer.TryParse(tbxPlayerDamage.Text, clsHero.intDamageCanCause) Then
            MessageBox.Show("Invalid or non-Integer Entry",
                "Validation Failure - Player Damage", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbxPlayerDamage.Focus()
            tbxPlayerDamage.SelectAll()
            Return
        End If

        'Set the Monster Class Object Properties
        If Not tbxMonsterType.Text.Trim.Length > 0 Then
            MessageBox.Show("Missing or blank Monster Type",
                "Validation Failure - Monster Type", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbxMonsterType.Focus()
            tbxMonsterType.SelectAll()
            Return
        End If
        clsMonster.strName = tbxMonsterType.Text.Trim

        If Not Integer.TryParse(tbxMonsterHealthPoints.Text, clsMonster.intHeathPoints) Then
            MessageBox.Show("Invalid or non-Integer Entry",
                "Validation Failure - Monster Health", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbxMonsterHealthPoints.Focus()
            tbxMonsterHealthPoints.SelectAll()
            Return
        End If

        If Not Integer.TryParse(tbxMonsterDamage.Text, clsMonster.intDamageCanCause) Then
            MessageBox.Show("Invalid or non-Integer Entry",
                "Validation Failure - Monster Damage", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbxMonsterDamage.Focus()
            tbxMonsterDamage.SelectAll()
            Return
        End If

        tbxMonsterDamage.Enabled = False
        tbxMonsterHealthPoints.Enabled = False
        tbxMonsterType.Enabled = False
        tbxPlayerDamage.Enabled = False
        tbxPlayerHealthPoints.Enabled = False
        tbxPlayerName.Enabled = False
        tbxPlayerTeamName.Enabled = False

        btnAttack.Enabled = True

        lbxAttackResults.Items.Add("Hero Name: " + clsHero.strName)
        lbxAttackResults.Items.Add("Hero Team: " + clsHero.strTeam)
        lbxAttackResults.Items.Add("Hero Health: " + clsHero.intHeathPoints.ToString)
        lbxAttackResults.Items.Add("Hero Damage Can Cause: " + clsHero.intDamageCanCause.ToString)
        lbxAttackResults.Items.Add("------------------------------------------")
        lbxAttackResults.Items.Add("Monster Name: " + clsMonster.strName)
        lbxAttackResults.Items.Add("Monster Health: " + clsMonster.intHeathPoints.ToString)
        lbxAttackResults.Items.Add("Monster Damage Can Cause: " + clsMonster.intDamageCanCause.ToString)
        lbxAttackResults.Items.Add("------------------------------------------")

        lblHeroRemainingHP.Text = clsHero.intHeathPoints.ToString
        lblMonsterRemainingHP.Text = clsMonster.intHeathPoints.ToString
        btnBeginCombat.Enabled = False
    End Sub

    Private Sub btnAttack_Click(sender As Object, e As EventArgs) Handles btnAttack.Click
        Dim bolHitSuccess As Boolean = False
        Dim rnd As New Random
        Dim intDamageDone As Integer = 0

        'A poor man's Random Hit Success Indicator
        'Hero's Attack
        bolHitSuccess = rnd.Next(0, 2) > 0
        If bolHitSuccess Then
            'lbxAttackResults.Items.Add("Hero Hit: " + bolHitSuccess.ToString)
            intDamageDone = rnd.Next(0, clsHero.intDamageCanCause)
            clsMonster.Attacked(intDamageDone)
            lbxAttackResults.Items.Add(clsHero.strName + " attacked and scored a hit. Damage Done: " + intDamageDone.ToString)
        Else
            'lbxAttackResults.Items.Add("Hero Miss: " + bolHitSuccess.ToString)
            lbxAttackResults.Items.Add(clsHero.strName + " Attacked and Missed")
        End If

        'Monster's Attack
        bolHitSuccess = rnd.Next(0, 2) > 0
        If bolHitSuccess Then
            'lbxAttackResults.Items.Add("Monster Hit: " + bolHitSuccess.ToString)
            intDamageDone = rnd.Next(0, clsMonster.intDamageCanCause)
            clsHero.Attacked(intDamageDone)
            lbxAttackResults.Items.Add(clsMonster.strName + " Attacked and scored a hit. Damage Done: " + intDamageDone.ToString)
        Else
            'lbxAttackResults.Items.Add("Monster Miss: " + bolHitSuccess.ToString)
            lbxAttackResults.Items.Add(clsMonster.strName + " Attacked and Missed")
        End If

        lbxAttackResults.Items.Add(" ")
        lbxAttackResults.SelectedIndex = lbxAttackResults.Items.Count - 1

        lblHeroRemainingHP.Text = clsHero.intHeathPoints.ToString
        lblMonsterRemainingHP.Text = clsMonster.intHeathPoints.ToString

        If clsHero.bolDead And clsMonster.bolDead Then
            MessageBox.Show(clsHero.strName + " and " + clsMonster.strName + " are Dead, Game Over!", "A Draw", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            btnAttack.Enabled = False
            Return
        End If

        If clsHero.bolDead Then
            MessageBox.Show(clsHero.strName + " is Dead, Game Over!", "Defeat!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            btnAttack.Enabled = False
        End If

        If clsMonster.bolDead Then
            MessageBox.Show(clsMonster.strName + " is Dead, Game Over!", "Victory!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            btnAttack.Enabled = False
        End If
    End Sub

End Class