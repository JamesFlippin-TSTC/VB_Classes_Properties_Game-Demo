'*******************************************
'*******************************************
'Programmer: James Flippin
'Course: ITSE 1332.10x1 (VB)
'Program purpose: Demonstration code using a
'                 Class file, Properties,
'                 Setters And Getters

'                 It is written so a "Restart"
'                 game Option can be added
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

        'Make sure we have an entry (non-blank)
        If Not tbxPlayerName.Text.Trim.Length > 0 Then
            MessageBox.Show("Missing or blank Player Name",
                "Validation Failure - Player Name", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbxPlayerName.Focus()
            tbxPlayerName.SelectAll()
            Return
        End If
        clsHero.strName = tbxPlayerName.Text.Trim

        'Make sure we have an entry (non-blank)
        If Not tbxPlayerTeamName.Text.Trim.Length > 0 Then
            MessageBox.Show("Missing or blank Player Team Name",
                "Validation Failure - Player Team Name", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbxPlayerTeamName.Focus()
            tbxPlayerTeamName.SelectAll()
            Return
        End If
        clsHero.strTeam = tbxPlayerTeamName.Text.Trim

        'Make sure we have a valid entry
        If Not Integer.TryParse(tbxPlayerHealthPoints.Text, clsHero.intHeathPoints) Then
            MessageBox.Show("Invalid or non-Integer Entry",
                "Validation Failure - Player Health", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbxPlayerHealthPoints.Focus()
            tbxPlayerHealthPoints.SelectAll()
            Return
        End If

        'Make sure we have a valid entry
        If Not Integer.TryParse(tbxPlayerDamage.Text, clsHero.intDamageCanCause) Then
            MessageBox.Show("Invalid or non-Integer Entry",
                "Validation Failure - Player Damage", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbxPlayerDamage.Focus()
            tbxPlayerDamage.SelectAll()
            Return
        End If

        'Set the Monster Class Object Properties
        'Make sure we have an entry (non-blank)
        If Not tbxMonsterType.Text.Trim.Length > 0 Then
            MessageBox.Show("Missing or blank Monster Type",
                "Validation Failure - Monster Type", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbxMonsterType.Focus()
            tbxMonsterType.SelectAll()
            Return
        End If
        clsMonster.strName = tbxMonsterType.Text.Trim

        'Make sure we have a valid entry
        If Not Integer.TryParse(tbxMonsterHealthPoints.Text, clsMonster.intHeathPoints) Then
            MessageBox.Show("Invalid or non-Integer Entry",
                "Validation Failure - Monster Health", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbxMonsterHealthPoints.Focus()
            tbxMonsterHealthPoints.SelectAll()
            Return
        End If

        'Make sure we have a valid entry
        If Not Integer.TryParse(tbxMonsterDamage.Text, clsMonster.intDamageCanCause) Then
            MessageBox.Show("Invalid or non-Integer Entry",
                "Validation Failure - Monster Damage", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbxMonsterDamage.Focus()
            tbxMonsterDamage.SelectAll()
            Return
        End If

        'Disable the ability to change the value so we can start the game
        tbxMonsterDamage.Enabled = False
        tbxMonsterHealthPoints.Enabled = False
        tbxMonsterType.Enabled = False
        tbxPlayerDamage.Enabled = False
        tbxPlayerHealthPoints.Enabled = False
        tbxPlayerName.Enabled = False
        tbxPlayerTeamName.Enabled = False

        'Enable the Attack Button
        btnAttack.Enabled = True

        'Display our Hero and Monster's information in the listbox
        lbxAttackResults.Items.Add("Hero Name: " + clsHero.strName)
        lbxAttackResults.Items.Add("Hero Team: " + clsHero.strTeam)
        lbxAttackResults.Items.Add("Hero Health: " + clsHero.intHeathPoints.ToString)
        lbxAttackResults.Items.Add("Hero Damage Can Cause: " + clsHero.intDamageCanCause.ToString)
        lbxAttackResults.Items.Add("------------------------------------------")
        lbxAttackResults.Items.Add("Monster Name: " + clsMonster.strName)
        lbxAttackResults.Items.Add("Monster Health: " + clsMonster.intHeathPoints.ToString)
        lbxAttackResults.Items.Add("Monster Damage Can Cause: " + clsMonster.intDamageCanCause.ToString)
        lbxAttackResults.Items.Add("------------------------------------------")

        'update out current/remaining health points labels
        lblHeroRemainingHP.Text = clsHero.intHeathPoints.ToString
        lblMonsterRemainingHP.Text = clsMonster.intHeathPoints.ToString

        'Disable the Begin Combat Button
        btnBeginCombat.Enabled = False

        'Change the form's accept button to the 'Attack' Button
        Me.AcceptButton = btnAttack
    End Sub

    Private Sub btnAttack_Click(sender As Object, e As EventArgs) Handles btnAttack.Click
        'Setup our variables we will need
        Dim bolHitSuccess As Boolean = False 'Flag to tell us if the attempt to hit/attack was successful for each
        Dim rnd As New Random   'Random Number generator
        Dim intDamageDone As Integer = 0 'How much damage was done during the attack

        'A poor man's Random Hit Success Indicator
        'Hero's Attack
        bolHitSuccess = rnd.Next(0, 2) > 0 'Used to indicate if, randomly, the attack was succesful or not
        If bolHitSuccess Then   'If the attack was successful
            intDamageDone = rnd.Next(0, clsHero.intDamageCanCause)  'Randomize how much damage was done based on how much they can do
            clsMonster.Attacked(intDamageDone) 'Update the Heath points buy passing the damage that was done
            'Provide some feedback via the listbox:
            lbxAttackResults.Items.Add(clsHero.strName + " attacked and scored a hit. Damage Done: " + intDamageDone.ToString)
        Else
            'Provide some feedback via the listbox:
            lbxAttackResults.Items.Add(clsHero.strName + " Attacked and Missed")
        End If

        'Monster's Attack
        bolHitSuccess = rnd.Next(0, 2) > 0 'Used to indicate if, randomly, the attack was succesful or not
        If bolHitSuccess Then   'If the attack was successful
            intDamageDone = rnd.Next(0, clsMonster.intDamageCanCause)  'Randomize how much damage was done based on how much they can do
            clsHero.Attacked(intDamageDone) 'Update the Heath points buy passing the damage that was done
            'Provide some feedback via the listbox:
            lbxAttackResults.Items.Add(clsMonster.strName + " Attacked and scored a hit. Damage Done: " + intDamageDone.ToString)
        Else
            'Provide some feedback via the listbox:
            lbxAttackResults.Items.Add(clsMonster.strName + " Attacked and Missed")
        End If

        'Provide some spacing in the listbox between entries
        lbxAttackResults.Items.Add(" ")

        'scroll the listbox to the last item in the list for better feedback
        lbxAttackResults.SelectedIndex = lbxAttackResults.Items.Count - 1

        'Update the current/remaining Healt points labels
        lblHeroRemainingHP.Text = clsHero.intHeathPoints.ToString
        lblMonsterRemainingHP.Text = clsMonster.intHeathPoints.ToString

        'Check to see if both Hero and Monster are dead. Provide feedback and end the game
        If clsHero.bolDead And clsMonster.bolDead Then
            MessageBox.Show(clsHero.strName + " and " + clsMonster.strName + " are Dead, Game Over!", "A Draw", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            btnAttack.Enabled = False
            Me.AcceptButton = btnBeginCombat
            Return
        End If

        'Check to see if the Hero is dead. Provide feedback and end the game
        If clsHero.bolDead Then
            MessageBox.Show(clsHero.strName + " is Dead, Game Over!", "Defeat!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            btnAttack.Enabled = False
            Me.AcceptButton = btnBeginCombat
        End If

        'Check to see if the Hero is dead. Provide feedback and end the game
        If clsMonster.bolDead Then
            MessageBox.Show(clsMonster.strName + " is Dead, Game Over!", "Victory!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            btnAttack.Enabled = False
            Me.AcceptButton = btnBeginCombat
        End If
    End Sub

End Class