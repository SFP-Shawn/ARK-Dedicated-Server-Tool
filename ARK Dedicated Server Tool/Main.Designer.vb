﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkShowPlayerMarker = New System.Windows.Forms.CheckBox()
        Me.chkServerHardcore = New System.Windows.Forms.CheckBox()
        Me.chkGlobalVoiceChat = New System.Windows.Forms.CheckBox()
        Me.chkProximityChat = New System.Windows.Forms.CheckBox()
        Me.chkAllowTributeDownloads = New System.Windows.Forms.CheckBox()
        Me.chkAlwaysNotifyPlayerJoined = New System.Windows.Forms.CheckBox()
        Me.chkDontAlwaysNotifyPlayerJoined = New System.Windows.Forms.CheckBox()
        Me.chkServerPVE = New System.Windows.Forms.CheckBox()
        Me.chkServerCrosshair = New System.Windows.Forms.CheckBox()
        Me.chkServerForceNoHUD = New System.Windows.Forms.CheckBox()
        Me.chkAllowThirdPersonPlayer = New System.Windows.Forms.CheckBox()
        Me.chkMessageOfTheDay = New System.Windows.Forms.CheckBox()
        Me.txtMessageOfTheDay = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMaxPlayers = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDifficultyOffset = New System.Windows.Forms.TextBox()
        Me.btnSaveConfig = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtServerPassword = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtAdminPassword = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtServerName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtServerPort = New System.Windows.Forms.TextBox()
        Me.btnUpdateServer = New System.Windows.Forms.Button()
        Me.btnLaunchServer = New System.Windows.Forms.Button()
        Me.btnStopServer = New System.Windows.Forms.Button()
        Me.btnInstallSteamCMD = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.chkScheduledUpdate = New System.Windows.Forms.CheckBox()
        Me.txtTime = New System.Windows.Forms.TextBox()
        Me.cmbTimeAMPM = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(37, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Server Options"
        '
        'chkShowPlayerMarker
        '
        Me.chkShowPlayerMarker.AutoSize = True
        Me.chkShowPlayerMarker.Location = New System.Drawing.Point(7, 32)
        Me.chkShowPlayerMarker.Name = "chkShowPlayerMarker"
        Me.chkShowPlayerMarker.Size = New System.Drawing.Size(160, 17)
        Me.chkShowPlayerMarker.TabIndex = 2
        Me.chkShowPlayerMarker.Text = "Show Player Marker on Map"
        Me.chkShowPlayerMarker.UseVisualStyleBackColor = True
        '
        'chkServerHardcore
        '
        Me.chkServerHardcore.AutoSize = True
        Me.chkServerHardcore.Location = New System.Drawing.Point(7, 56)
        Me.chkServerHardcore.Name = "chkServerHardcore"
        Me.chkServerHardcore.Size = New System.Drawing.Size(134, 17)
        Me.chkServerHardcore.TabIndex = 3
        Me.chkServerHardcore.Text = "Make Server Hardcore"
        Me.chkServerHardcore.UseVisualStyleBackColor = True
        '
        'chkGlobalVoiceChat
        '
        Me.chkGlobalVoiceChat.AutoSize = True
        Me.chkGlobalVoiceChat.Location = New System.Drawing.Point(7, 79)
        Me.chkGlobalVoiceChat.Name = "chkGlobalVoiceChat"
        Me.chkGlobalVoiceChat.Size = New System.Drawing.Size(111, 17)
        Me.chkGlobalVoiceChat.TabIndex = 4
        Me.chkGlobalVoiceChat.Text = "Global Voice Chat"
        Me.chkGlobalVoiceChat.UseVisualStyleBackColor = True
        '
        'chkProximityChat
        '
        Me.chkProximityChat.AutoSize = True
        Me.chkProximityChat.Location = New System.Drawing.Point(7, 102)
        Me.chkProximityChat.Name = "chkProximityChat"
        Me.chkProximityChat.Size = New System.Drawing.Size(116, 17)
        Me.chkProximityChat.TabIndex = 5
        Me.chkProximityChat.Text = "Proximity Text Chat"
        Me.chkProximityChat.UseVisualStyleBackColor = True
        '
        'chkAllowTributeDownloads
        '
        Me.chkAllowTributeDownloads.AutoSize = True
        Me.chkAllowTributeDownloads.Location = New System.Drawing.Point(7, 125)
        Me.chkAllowTributeDownloads.Name = "chkAllowTributeDownloads"
        Me.chkAllowTributeDownloads.Size = New System.Drawing.Size(132, 17)
        Me.chkAllowTributeDownloads.TabIndex = 6
        Me.chkAllowTributeDownloads.Text = "No Tribute Downloads"
        Me.chkAllowTributeDownloads.UseVisualStyleBackColor = True
        '
        'chkAlwaysNotifyPlayerJoined
        '
        Me.chkAlwaysNotifyPlayerJoined.AutoSize = True
        Me.chkAlwaysNotifyPlayerJoined.Location = New System.Drawing.Point(7, 148)
        Me.chkAlwaysNotifyPlayerJoined.Name = "chkAlwaysNotifyPlayerJoined"
        Me.chkAlwaysNotifyPlayerJoined.Size = New System.Drawing.Size(147, 17)
        Me.chkAlwaysNotifyPlayerJoined.TabIndex = 7
        Me.chkAlwaysNotifyPlayerJoined.Text = """Player Left"" Notifications"
        Me.chkAlwaysNotifyPlayerJoined.UseVisualStyleBackColor = True
        '
        'chkDontAlwaysNotifyPlayerJoined
        '
        Me.chkDontAlwaysNotifyPlayerJoined.AutoSize = True
        Me.chkDontAlwaysNotifyPlayerJoined.Location = New System.Drawing.Point(7, 171)
        Me.chkDontAlwaysNotifyPlayerJoined.Name = "chkDontAlwaysNotifyPlayerJoined"
        Me.chkDontAlwaysNotifyPlayerJoined.Size = New System.Drawing.Size(177, 17)
        Me.chkDontAlwaysNotifyPlayerJoined.TabIndex = 8
        Me.chkDontAlwaysNotifyPlayerJoined.Text = "No ""Player Joined"" Notifications"
        Me.chkDontAlwaysNotifyPlayerJoined.UseVisualStyleBackColor = True
        '
        'chkServerPVE
        '
        Me.chkServerPVE.AutoSize = True
        Me.chkServerPVE.Location = New System.Drawing.Point(7, 194)
        Me.chkServerPVE.Name = "chkServerPVE"
        Me.chkServerPVE.Size = New System.Drawing.Size(80, 17)
        Me.chkServerPVE.TabIndex = 9
        Me.chkServerPVE.Text = "PvE Server"
        Me.chkServerPVE.UseVisualStyleBackColor = True
        '
        'chkServerCrosshair
        '
        Me.chkServerCrosshair.AutoSize = True
        Me.chkServerCrosshair.Location = New System.Drawing.Point(7, 217)
        Me.chkServerCrosshair.Name = "chkServerCrosshair"
        Me.chkServerCrosshair.Size = New System.Drawing.Size(105, 17)
        Me.chkServerCrosshair.TabIndex = 10
        Me.chkServerCrosshair.Text = "Enable Crosshair"
        Me.chkServerCrosshair.UseVisualStyleBackColor = True
        '
        'chkServerForceNoHUD
        '
        Me.chkServerForceNoHUD.AutoSize = True
        Me.chkServerForceNoHUD.Location = New System.Drawing.Point(7, 240)
        Me.chkServerForceNoHUD.Name = "chkServerForceNoHUD"
        Me.chkServerForceNoHUD.Size = New System.Drawing.Size(97, 17)
        Me.chkServerForceNoHUD.TabIndex = 11
        Me.chkServerForceNoHUD.Text = "Force No HUD"
        Me.chkServerForceNoHUD.UseVisualStyleBackColor = True
        '
        'chkAllowThirdPersonPlayer
        '
        Me.chkAllowThirdPersonPlayer.AutoSize = True
        Me.chkAllowThirdPersonPlayer.Location = New System.Drawing.Point(7, 263)
        Me.chkAllowThirdPersonPlayer.Name = "chkAllowThirdPersonPlayer"
        Me.chkAllowThirdPersonPlayer.Size = New System.Drawing.Size(122, 17)
        Me.chkAllowThirdPersonPlayer.TabIndex = 12
        Me.chkAllowThirdPersonPlayer.Text = "Enable Third Person"
        Me.chkAllowThirdPersonPlayer.UseVisualStyleBackColor = True
        '
        'chkMessageOfTheDay
        '
        Me.chkMessageOfTheDay.AutoSize = True
        Me.chkMessageOfTheDay.Checked = True
        Me.chkMessageOfTheDay.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkMessageOfTheDay.Location = New System.Drawing.Point(7, 287)
        Me.chkMessageOfTheDay.Name = "chkMessageOfTheDay"
        Me.chkMessageOfTheDay.Size = New System.Drawing.Size(121, 17)
        Me.chkMessageOfTheDay.TabIndex = 13
        Me.chkMessageOfTheDay.Text = "Message of the Day"
        Me.chkMessageOfTheDay.UseVisualStyleBackColor = True
        '
        'txtMessageOfTheDay
        '
        Me.txtMessageOfTheDay.Location = New System.Drawing.Point(7, 311)
        Me.txtMessageOfTheDay.Name = "txtMessageOfTheDay"
        Me.txtMessageOfTheDay.Size = New System.Drawing.Size(177, 20)
        Me.txtMessageOfTheDay.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(199, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Max Players (Limit 127)"
        '
        'txtMaxPlayers
        '
        Me.txtMaxPlayers.Location = New System.Drawing.Point(217, 27)
        Me.txtMaxPlayers.Name = "txtMaxPlayers"
        Me.txtMaxPlayers.Size = New System.Drawing.Size(100, 20)
        Me.txtMaxPlayers.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(199, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Difficulty Offset (0 - 1)"
        '
        'txtDifficultyOffset
        '
        Me.txtDifficultyOffset.Location = New System.Drawing.Point(217, 73)
        Me.txtDifficultyOffset.Name = "txtDifficultyOffset"
        Me.txtDifficultyOffset.Size = New System.Drawing.Size(100, 20)
        Me.txtDifficultyOffset.TabIndex = 18
        '
        'btnSaveConfig
        '
        Me.btnSaveConfig.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveConfig.Location = New System.Drawing.Point(373, 200)
        Me.btnSaveConfig.Name = "btnSaveConfig"
        Me.btnSaveConfig.Size = New System.Drawing.Size(88, 23)
        Me.btnSaveConfig.TabIndex = 19
        Me.btnSaveConfig.Text = "Save Config"
        Me.btnSaveConfig.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(215, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Server Password"
        '
        'txtServerPassword
        '
        Me.txtServerPassword.Location = New System.Drawing.Point(202, 118)
        Me.txtServerPassword.Name = "txtServerPassword"
        Me.txtServerPassword.Size = New System.Drawing.Size(130, 20)
        Me.txtServerPassword.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(218, 149)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Admin Password"
        '
        'txtAdminPassword
        '
        Me.txtAdminPassword.Location = New System.Drawing.Point(202, 165)
        Me.txtAdminPassword.Name = "txtAdminPassword"
        Me.txtAdminPassword.Size = New System.Drawing.Size(130, 20)
        Me.txtAdminPassword.TabIndex = 23
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(227, 195)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 13)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Server Name"
        '
        'txtServerName
        '
        Me.txtServerName.Location = New System.Drawing.Point(202, 211)
        Me.txtServerName.Name = "txtServerName"
        Me.txtServerName.Size = New System.Drawing.Size(130, 20)
        Me.txtServerName.TabIndex = 25
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(230, 241)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 13)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Server Port"
        '
        'txtServerPort
        '
        Me.txtServerPort.Location = New System.Drawing.Point(202, 257)
        Me.txtServerPort.Name = "txtServerPort"
        Me.txtServerPort.Size = New System.Drawing.Size(130, 20)
        Me.txtServerPort.TabIndex = 28
        '
        'btnUpdateServer
        '
        Me.btnUpdateServer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateServer.Location = New System.Drawing.Point(516, 229)
        Me.btnUpdateServer.Name = "btnUpdateServer"
        Me.btnUpdateServer.Size = New System.Drawing.Size(101, 23)
        Me.btnUpdateServer.TabIndex = 29
        Me.btnUpdateServer.Text = "Update Server"
        Me.btnUpdateServer.UseVisualStyleBackColor = True
        '
        'btnLaunchServer
        '
        Me.btnLaunchServer.Location = New System.Drawing.Point(516, 171)
        Me.btnLaunchServer.Name = "btnLaunchServer"
        Me.btnLaunchServer.Size = New System.Drawing.Size(101, 23)
        Me.btnLaunchServer.TabIndex = 30
        Me.btnLaunchServer.Text = "Launch Server"
        Me.btnLaunchServer.UseVisualStyleBackColor = True
        '
        'btnStopServer
        '
        Me.btnStopServer.Location = New System.Drawing.Point(516, 200)
        Me.btnStopServer.Name = "btnStopServer"
        Me.btnStopServer.Size = New System.Drawing.Size(101, 23)
        Me.btnStopServer.TabIndex = 31
        Me.btnStopServer.Text = "Stop Server"
        Me.btnStopServer.UseVisualStyleBackColor = True
        '
        'btnInstallSteamCMD
        '
        Me.btnInstallSteamCMD.Location = New System.Drawing.Point(365, 171)
        Me.btnInstallSteamCMD.Name = "btnInstallSteamCMD"
        Me.btnInstallSteamCMD.Size = New System.Drawing.Size(106, 23)
        Me.btnInstallSteamCMD.TabIndex = 32
        Me.btnInstallSteamCMD.Text = "Install SteamCMD"
        Me.btnInstallSteamCMD.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(362, 3)
        Me.Label8.MaximumSize = New System.Drawing.Size(294, 143)
        Me.Label8.MinimumSize = New System.Drawing.Size(294, 143)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(294, 143)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = resources.GetString("Label8.Text")
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Location = New System.Drawing.Point(567, 318)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(39, 13)
        Me.lblVersion.TabIndex = 34
        Me.lblVersion.Text = "Label9"
        '
        'chkScheduledUpdate
        '
        Me.chkScheduledUpdate.AutoSize = True
        Me.chkScheduledUpdate.Enabled = False
        Me.chkScheduledUpdate.Location = New System.Drawing.Point(365, 256)
        Me.chkScheduledUpdate.Name = "chkScheduledUpdate"
        Me.chkScheduledUpdate.Size = New System.Drawing.Size(120, 17)
        Me.chkScheduledUpdate.TabIndex = 36
        Me.chkScheduledUpdate.Text = "Scheduled Updates"
        Me.chkScheduledUpdate.UseVisualStyleBackColor = True
        '
        'txtTime
        '
        Me.txtTime.Enabled = False
        Me.txtTime.Location = New System.Drawing.Point(365, 299)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(64, 20)
        Me.txtTime.TabIndex = 37
        '
        'cmbTimeAMPM
        '
        Me.cmbTimeAMPM.Enabled = False
        Me.cmbTimeAMPM.FormattingEnabled = True
        Me.cmbTimeAMPM.Items.AddRange(New Object() {"AM", "PM"})
        Me.cmbTimeAMPM.Location = New System.Drawing.Point(435, 299)
        Me.cmbTimeAMPM.Name = "cmbTimeAMPM"
        Me.cmbTimeAMPM.Size = New System.Drawing.Size(38, 21)
        Me.cmbTimeAMPM.TabIndex = 38
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Enabled = False
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(370, 283)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(101, 13)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "Time (Eg. 12:00)"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(663, 336)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cmbTimeAMPM)
        Me.Controls.Add(Me.txtTime)
        Me.Controls.Add(Me.chkScheduledUpdate)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnInstallSteamCMD)
        Me.Controls.Add(Me.btnStopServer)
        Me.Controls.Add(Me.btnLaunchServer)
        Me.Controls.Add(Me.btnUpdateServer)
        Me.Controls.Add(Me.txtServerPort)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtServerName)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtAdminPassword)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtServerPassword)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnSaveConfig)
        Me.Controls.Add(Me.txtDifficultyOffset)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtMaxPlayers)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtMessageOfTheDay)
        Me.Controls.Add(Me.chkMessageOfTheDay)
        Me.Controls.Add(Me.chkAllowThirdPersonPlayer)
        Me.Controls.Add(Me.chkServerForceNoHUD)
        Me.Controls.Add(Me.chkServerCrosshair)
        Me.Controls.Add(Me.chkServerPVE)
        Me.Controls.Add(Me.chkDontAlwaysNotifyPlayerJoined)
        Me.Controls.Add(Me.chkAlwaysNotifyPlayerJoined)
        Me.Controls.Add(Me.chkAllowTributeDownloads)
        Me.Controls.Add(Me.chkProximityChat)
        Me.Controls.Add(Me.chkGlobalVoiceChat)
        Me.Controls.Add(Me.chkServerHardcore)
        Me.Controls.Add(Me.chkShowPlayerMarker)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(679, 374)
        Me.MinimumSize = New System.Drawing.Size(679, 374)
        Me.Name = "Main"
        Me.Text = "ARK: Survival Evolved - Server Tool"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chkShowPlayerMarker As System.Windows.Forms.CheckBox
    Friend WithEvents chkServerHardcore As System.Windows.Forms.CheckBox
    Friend WithEvents chkGlobalVoiceChat As System.Windows.Forms.CheckBox
    Friend WithEvents chkProximityChat As System.Windows.Forms.CheckBox
    Friend WithEvents chkAllowTributeDownloads As System.Windows.Forms.CheckBox
    Friend WithEvents chkAlwaysNotifyPlayerJoined As System.Windows.Forms.CheckBox
    Friend WithEvents chkDontAlwaysNotifyPlayerJoined As System.Windows.Forms.CheckBox
    Friend WithEvents chkServerPVE As System.Windows.Forms.CheckBox
    Friend WithEvents chkServerCrosshair As System.Windows.Forms.CheckBox
    Friend WithEvents chkServerForceNoHUD As System.Windows.Forms.CheckBox
    Friend WithEvents chkAllowThirdPersonPlayer As System.Windows.Forms.CheckBox
    Friend WithEvents chkMessageOfTheDay As System.Windows.Forms.CheckBox
    Friend WithEvents txtMessageOfTheDay As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtMaxPlayers As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDifficultyOffset As System.Windows.Forms.TextBox
    Friend WithEvents btnSaveConfig As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtServerPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtAdminPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtServerName As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtServerPort As System.Windows.Forms.TextBox
    Friend WithEvents btnUpdateServer As System.Windows.Forms.Button
    Friend WithEvents btnLaunchServer As System.Windows.Forms.Button
    Friend WithEvents btnStopServer As System.Windows.Forms.Button
    Friend WithEvents btnInstallSteamCMD As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblVersion As System.Windows.Forms.Label
    Friend WithEvents chkScheduledUpdate As System.Windows.Forms.CheckBox
    Friend WithEvents txtTime As System.Windows.Forms.TextBox
    Friend WithEvents cmbTimeAMPM As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label

End Class
