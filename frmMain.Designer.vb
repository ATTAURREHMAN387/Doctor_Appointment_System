<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MyDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewBookingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CancToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MyDetailsToolStripMenuItem, Me.BookToolStripMenuItem, Me.ViewBookingToolStripMenuItem, Me.ToolStripMenuItem1, Me.CancToolStripMenuItem, Me.AboutToolStripMenuItem, Me.LogoutToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MenuStrip1.Size = New System.Drawing.Size(891, 24)
        Me.MenuStrip1.TabIndex = 42
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MyDetailsToolStripMenuItem
        '
        Me.MyDetailsToolStripMenuItem.Name = "MyDetailsToolStripMenuItem"
        Me.MyDetailsToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.MyDetailsToolStripMenuItem.Text = "My Details"
        '
        'BookToolStripMenuItem
        '
        Me.BookToolStripMenuItem.Name = "BookToolStripMenuItem"
        Me.BookToolStripMenuItem.Size = New System.Drawing.Size(118, 20)
        Me.BookToolStripMenuItem.Text = "Book Appoitments"
        '
        'ViewBookingToolStripMenuItem
        '
        Me.ViewBookingToolStripMenuItem.Name = "ViewBookingToolStripMenuItem"
        Me.ViewBookingToolStripMenuItem.Size = New System.Drawing.Size(96, 20)
        Me.ViewBookingToolStripMenuItem.Text = "View Bookings"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(97, 20)
        Me.ToolStripMenuItem1.Text = "Patient History"
        '
        'CancToolStripMenuItem
        '
        Me.CancToolStripMenuItem.Name = "CancToolStripMenuItem"
        Me.CancToolStripMenuItem.Size = New System.Drawing.Size(102, 20)
        Me.CancToolStripMenuItem.Text = "Cancel Booking"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'LogoutToolStripMenuItem1
        '
        Me.LogoutToolStripMenuItem1.Name = "LogoutToolStripMenuItem1"
        Me.LogoutToolStripMenuItem1.Size = New System.Drawing.Size(57, 20)
        Me.LogoutToolStripMenuItem1.Text = "Logout"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(21, 54)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(766, 39)
        Me.LinkLabel1.TabIndex = 44
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Attiq Clinic Appointment Management System"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(891, 500)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Doctor Appointment System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MyDetailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BookToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewBookingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CancToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
