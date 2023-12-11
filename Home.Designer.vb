<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.kataloug = New System.Windows.Forms.TabPage()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnBeli = New System.Windows.Forms.Button()
        Me.comboLaptop = New System.Windows.Forms.ComboBox()
        Me.tbHarga = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.numJumlah = New System.Windows.Forms.NumericUpDown()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tabelLaporan = New System.Windows.Forms.DataGridView()
        Me.No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.laptop = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.harga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jumlakh = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tot = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.kataloug.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.numJumlah, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        CType(Me.tabelLaporan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.kataloug)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(804, 450)
        Me.TabControl1.TabIndex = 0
        '
        'kataloug
        '
        Me.kataloug.Controls.Add(Me.Label6)
        Me.kataloug.Controls.Add(Me.Label7)
        Me.kataloug.Controls.Add(Me.Label5)
        Me.kataloug.Controls.Add(Me.Label4)
        Me.kataloug.Controls.Add(Me.Label3)
        Me.kataloug.Controls.Add(Me.Label2)
        Me.kataloug.Controls.Add(Me.PictureBox3)
        Me.kataloug.Controls.Add(Me.PictureBox1)
        Me.kataloug.Location = New System.Drawing.Point(4, 25)
        Me.kataloug.Name = "kataloug"
        Me.kataloug.Padding = New System.Windows.Forms.Padding(3)
        Me.kataloug.Size = New System.Drawing.Size(796, 421)
        Me.kataloug.TabIndex = 0
        Me.kataloug.Text = "Katalog Laptop"
        Me.kataloug.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(300, 258)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 16)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Rp16.000.000"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(31, 258)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 16)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Rp30.000.000"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(31, 194)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 16)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Acer Predator Helios"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(300, 194)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Acer Nitro 5"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(300, 229)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Baru"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 229)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Baru"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(303, 27)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(174, 140)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(34, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(174, 140)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.btnBeli)
        Me.TabPage2.Controls.Add(Me.comboLaptop)
        Me.TabPage2.Controls.Add(Me.tbHarga)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.numJumlah)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(796, 421)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Input Transaksi"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(41, 212)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(50, 16)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "Jumlah"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(41, 150)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 16)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Harga"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(41, 91)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 16)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Laptop"
        '
        'btnBeli
        '
        Me.btnBeli.Location = New System.Drawing.Point(37, 280)
        Me.btnBeli.Name = "btnBeli"
        Me.btnBeli.Size = New System.Drawing.Size(156, 35)
        Me.btnBeli.TabIndex = 5
        Me.btnBeli.Text = "Beli"
        Me.btnBeli.UseVisualStyleBackColor = True
        '
        'comboLaptop
        '
        Me.comboLaptop.FormattingEnabled = True
        Me.comboLaptop.Items.AddRange(New Object() {"Acer Predator Helios", "Acer Nitro 5"})
        Me.comboLaptop.Location = New System.Drawing.Point(37, 115)
        Me.comboLaptop.Name = "comboLaptop"
        Me.comboLaptop.Size = New System.Drawing.Size(170, 24)
        Me.comboLaptop.TabIndex = 3
        '
        'tbHarga
        '
        Me.tbHarga.Location = New System.Drawing.Point(37, 171)
        Me.tbHarga.Name = "tbHarga"
        Me.tbHarga.ReadOnly = True
        Me.tbHarga.Size = New System.Drawing.Size(170, 22)
        Me.tbHarga.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(32, 42)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(196, 29)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Kasir Penjualan"
        '
        'numJumlah
        '
        Me.numJumlah.Location = New System.Drawing.Point(37, 231)
        Me.numJumlah.Name = "numJumlah"
        Me.numJumlah.Size = New System.Drawing.Size(156, 22)
        Me.numJumlah.TabIndex = 0
        Me.numJumlah.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.tabelLaporan)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(796, 421)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "Laporan Penjualan"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(362, 53)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(120, 16)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Laporan Penjualan"
        '
        'tabelLaporan
        '
        Me.tabelLaporan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabelLaporan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.No, Me.laptop, Me.harga, Me.jumlakh, Me.tot})
        Me.tabelLaporan.Location = New System.Drawing.Point(8, 133)
        Me.tabelLaporan.Name = "tabelLaporan"
        Me.tabelLaporan.RowHeadersWidth = 51
        Me.tabelLaporan.RowTemplate.Height = 24
        Me.tabelLaporan.Size = New System.Drawing.Size(776, 225)
        Me.tabelLaporan.TabIndex = 0
        '
        'No
        '
        Me.No.HeaderText = "No"
        Me.No.MinimumWidth = 6
        Me.No.Name = "No"
        Me.No.ReadOnly = True
        Me.No.Width = 125
        '
        'laptop
        '
        Me.laptop.HeaderText = "Laptop"
        Me.laptop.MinimumWidth = 6
        Me.laptop.Name = "laptop"
        Me.laptop.ReadOnly = True
        Me.laptop.Width = 125
        '
        'harga
        '
        Me.harga.HeaderText = "Harga Satuan"
        Me.harga.MinimumWidth = 6
        Me.harga.Name = "harga"
        Me.harga.ReadOnly = True
        Me.harga.Width = 125
        '
        'jumlakh
        '
        Me.jumlakh.HeaderText = "Qty"
        Me.jumlakh.MinimumWidth = 6
        Me.jumlakh.Name = "jumlakh"
        Me.jumlakh.ReadOnly = True
        Me.jumlakh.Width = 125
        '
        'tot
        '
        Me.tot.HeaderText = "Total Harga"
        Me.tot.MinimumWidth = 6
        Me.tot.Name = "tot"
        Me.tot.ReadOnly = True
        Me.tot.Width = 125
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Button1)
        Me.TabPage3.Controls.Add(Me.Label1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(796, 421)
        Me.TabPage3.TabIndex = 3
        Me.TabPage3.Text = "Logout"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(242, 181)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(308, 54)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Logout"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(261, 134)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(277, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Klik tombol dibawah untuk logout!"
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Home"
        Me.Text = "Home"
        Me.TabControl1.ResumeLayout(False)
        Me.kataloug.ResumeLayout(False)
        Me.kataloug.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.numJumlah, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.tabelLaporan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents kataloug As TabPage
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnBeli As Button
    Friend WithEvents comboLaptop As ComboBox
    Friend WithEvents tbHarga As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents numJumlah As NumericUpDown
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents tabelLaporan As DataGridView
    Friend WithEvents Label12 As Label
    Friend WithEvents No As DataGridViewTextBoxColumn
    Friend WithEvents laptop As DataGridViewTextBoxColumn
    Friend WithEvents harga As DataGridViewTextBoxColumn
    Friend WithEvents jumlakh As DataGridViewTextBoxColumn
    Friend WithEvents tot As DataGridViewTextBoxColumn
End Class
