<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.mnuPrincipal = New System.Windows.Forms.MenuStrip()
        Me.mnuArchivos = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTransacciones = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuInformes = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClientes = New System.Windows.Forms.ToolStripMenuItem()
        Me.tlsPrincipal = New System.Windows.Forms.ToolStrip()
        Me.btnClientes = New System.Windows.Forms.ToolStripButton()
        Me.stsPrincipal = New System.Windows.Forms.StatusStrip()
        Me.lblFechaHora = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ntiPrincipal = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.cmsPrincipal = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmsArchivos = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsTransacciones = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsClientes = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrincipal.SuspendLayout()
        Me.tlsPrincipal.SuspendLayout()
        Me.stsPrincipal.SuspendLayout()
        Me.cmsPrincipal.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuPrincipal
        '
        Me.mnuPrincipal.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mnuPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuArchivos, Me.mnuTransacciones, Me.mnuInformes})
        Me.mnuPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.mnuPrincipal.Name = "mnuPrincipal"
        Me.mnuPrincipal.Size = New System.Drawing.Size(1074, 28)
        Me.mnuPrincipal.TabIndex = 1
        Me.mnuPrincipal.Text = "MenuStrip1"
        '
        'mnuArchivos
        '
        Me.mnuArchivos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClientes})
        Me.mnuArchivos.Name = "mnuArchivos"
        Me.mnuArchivos.Size = New System.Drawing.Size(77, 24)
        Me.mnuArchivos.Text = "&Archivos"
        '
        'mnuTransacciones
        '
        Me.mnuTransacciones.Name = "mnuTransacciones"
        Me.mnuTransacciones.Size = New System.Drawing.Size(112, 24)
        Me.mnuTransacciones.Text = "&Transacciones"
        '
        'mnuInformes
        '
        Me.mnuInformes.Name = "mnuInformes"
        Me.mnuInformes.Size = New System.Drawing.Size(79, 24)
        Me.mnuInformes.Text = "&Informes"
        '
        'mnuClientes
        '
        Me.mnuClientes.Name = "mnuClientes"
        Me.mnuClientes.Size = New System.Drawing.Size(181, 26)
        Me.mnuClientes.Text = "&Clientes"
        '
        'tlsPrincipal
        '
        Me.tlsPrincipal.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tlsPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnClientes})
        Me.tlsPrincipal.Location = New System.Drawing.Point(0, 28)
        Me.tlsPrincipal.Name = "tlsPrincipal"
        Me.tlsPrincipal.Size = New System.Drawing.Size(1074, 27)
        Me.tlsPrincipal.TabIndex = 2
        Me.tlsPrincipal.Text = "ToolStrip1"
        '
        'btnClientes
        '
        Me.btnClientes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnClientes.Image = CType(resources.GetObject("btnClientes.Image"), System.Drawing.Image)
        Me.btnClientes.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Size = New System.Drawing.Size(24, 24)
        Me.btnClientes.Text = "ToolStripButton1"
        '
        'stsPrincipal
        '
        Me.stsPrincipal.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.stsPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblFechaHora})
        Me.stsPrincipal.Location = New System.Drawing.Point(0, 442)
        Me.stsPrincipal.Name = "stsPrincipal"
        Me.stsPrincipal.Size = New System.Drawing.Size(1074, 25)
        Me.stsPrincipal.TabIndex = 3
        Me.stsPrincipal.Text = "StatusStrip1"
        '
        'lblFechaHora
        '
        Me.lblFechaHora.Name = "lblFechaHora"
        Me.lblFechaHora.Size = New System.Drawing.Size(93, 20)
        Me.lblFechaHora.Text = "Fecha/Hora: "
        '
        'ntiPrincipal
        '
        Me.ntiPrincipal.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ntiPrincipal.BalloonTipText = "Bienvenido al Sistema"
        Me.ntiPrincipal.BalloonTipTitle = "Sistema Stock"
        Me.ntiPrincipal.Icon = CType(resources.GetObject("ntiPrincipal.Icon"), System.Drawing.Icon)
        Me.ntiPrincipal.Text = "Sistema Stock"
        Me.ntiPrincipal.Visible = True
        '
        'cmsPrincipal
        '
        Me.cmsPrincipal.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmsArchivos, Me.cmsTransacciones})
        Me.cmsPrincipal.Name = "cmsPrincipal"
        Me.cmsPrincipal.Size = New System.Drawing.Size(176, 80)
        '
        'cmsArchivos
        '
        Me.cmsArchivos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmsClientes})
        Me.cmsArchivos.Name = "cmsArchivos"
        Me.cmsArchivos.Size = New System.Drawing.Size(175, 24)
        Me.cmsArchivos.Text = "&Archivos"
        '
        'cmsTransacciones
        '
        Me.cmsTransacciones.Name = "cmsTransacciones"
        Me.cmsTransacciones.Size = New System.Drawing.Size(175, 24)
        Me.cmsTransacciones.Text = "&Transacciones"
        '
        'cmsClientes
        '
        Me.cmsClientes.Name = "cmsClientes"
        Me.cmsClientes.Size = New System.Drawing.Size(181, 26)
        Me.cmsClientes.Text = "&Clientes"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1074, 467)
        Me.ContextMenuStrip = Me.cmsPrincipal
        Me.Controls.Add(Me.stsPrincipal)
        Me.Controls.Add(Me.tlsPrincipal)
        Me.Controls.Add(Me.mnuPrincipal)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.mnuPrincipal
        Me.Name = "frmPrincipal"
        Me.Text = "Menú Principal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.mnuPrincipal.ResumeLayout(False)
        Me.mnuPrincipal.PerformLayout()
        Me.tlsPrincipal.ResumeLayout(False)
        Me.tlsPrincipal.PerformLayout()
        Me.stsPrincipal.ResumeLayout(False)
        Me.stsPrincipal.PerformLayout()
        Me.cmsPrincipal.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuPrincipal As MenuStrip
    Friend WithEvents mnuArchivos As ToolStripMenuItem
    Friend WithEvents mnuTransacciones As ToolStripMenuItem
    Friend WithEvents mnuInformes As ToolStripMenuItem
    Friend WithEvents mnuClientes As ToolStripMenuItem
    Friend WithEvents tlsPrincipal As ToolStrip
    Friend WithEvents btnClientes As ToolStripButton
    Friend WithEvents stsPrincipal As StatusStrip
    Friend WithEvents lblFechaHora As ToolStripStatusLabel
    Friend WithEvents ntiPrincipal As NotifyIcon
    Friend WithEvents cmsPrincipal As ContextMenuStrip
    Friend WithEvents cmsArchivos As ToolStripMenuItem
    Friend WithEvents cmsClientes As ToolStripMenuItem
    Friend WithEvents cmsTransacciones As ToolStripMenuItem
End Class
