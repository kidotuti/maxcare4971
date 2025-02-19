using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using MetroFramework.Controls;

public class fCauHinhQuetNhom : Form
{
	public static bool bool_0;

	private GClass17 gclass17_0;

	private IContainer icontainer_0 = null;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Button btnMinimize;

	private Button btnCancel;

	private Button btnAdd;

	private BunifuDragControl bunifuDragControl_0;

	private PictureBox pictureBox1;

	private Label label1;

	private Label label2;

	private RadioButton rbXuatAll;

	private RadioButton rbXuatNhomKiemDuyet;

	private RadioButton rbXuatNhomKhongKiemDuyet;

	private MetroButton metroButton1;

	public fCauHinhQuetNhom()
	{
		InitializeComponent();
		method_0();
		gclass17_0 = new GClass17("configGeneral");
		bool_0 = false;
	}

	private void method_0()
	{
		GClass29.smethod_1(bunifuCustomLabel1);
		GClass29.smethod_1(btnAdd);
		GClass29.smethod_1(btnCancel);
	}

	private void btnMinimize_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		if (rbXuatNhomKiemDuyet.Checked || !rbXuatNhomKhongKiemDuyet.Checked)
		{
		}
		gclass17_0.method_8();
		bool_0 = true;
		Close();
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void fCauHinhQuetNhom_Load(object sender, EventArgs e)
	{
		switch (gclass17_0.method_2("typeQuetNhom"))
		{
		case 0:
			rbXuatAll.Checked = true;
			break;
		case 1:
			rbXuatNhomKiemDuyet.Checked = true;
			break;
		default:
			rbXuatNhomKhongKiemDuyet.Checked = true;
			break;
		}
	}

	private void metroButton1_Click(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fCauHinhChung());
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	private void InitializeComponent()
	{
		this.icontainer_0 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fCauHinhQuetNhom));
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.btnMinimize = new System.Windows.Forms.Button();
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.btnCancel = new System.Windows.Forms.Button();
		this.btnAdd = new System.Windows.Forms.Button();
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.label1 = new System.Windows.Forms.Label();
		this.label2 = new System.Windows.Forms.Label();
		this.rbXuatAll = new System.Windows.Forms.RadioButton();
		this.rbXuatNhomKiemDuyet = new System.Windows.Forms.RadioButton();
		this.rbXuatNhomKhongKiemDuyet = new System.Windows.Forms.RadioButton();
		this.metroButton1 = new MetroFramework.Controls.MetroButton();
		this.bunifuCards1.SuspendLayout();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		base.SuspendLayout();
		this.bunifuCards1.BackColor = System.Drawing.Color.White;
		this.bunifuCards1.BorderRadius = 0;
		this.bunifuCards1.BottomSahddow = true;
		this.bunifuCards1.color = System.Drawing.Color.SaddleBrown;
		this.bunifuCards1.Controls.Add(this.pnlHeader);
		this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Top;
		this.bunifuCards1.LeftSahddow = false;
		this.bunifuCards1.Location = new System.Drawing.Point(0, 0);
		this.bunifuCards1.Name = "bunifuCards1";
		this.bunifuCards1.RightSahddow = true;
		this.bunifuCards1.ShadowDepth = 20;
		this.bunifuCards1.Size = new System.Drawing.Size(354, 34);
		this.bunifuCards1.TabIndex = 0;
		this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.pnlHeader.BackColor = System.Drawing.Color.White;
		this.pnlHeader.Controls.Add(this.pictureBox1);
		this.pnlHeader.Controls.Add(this.btnMinimize);
		this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
		this.pnlHeader.Location = new System.Drawing.Point(0, 3);
		this.pnlHeader.Name = "pnlHeader";
		this.pnlHeader.Size = new System.Drawing.Size(352, 28);
		this.pnlHeader.TabIndex = 9;
		this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		this.pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		this.pictureBox1.Location = new System.Drawing.Point(3, 2);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(34, 27);
		this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.pictureBox1.TabIndex = 17;
		this.pictureBox1.TabStop = false;
		this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
		this.btnMinimize.FlatAppearance.BorderSize = 0;
		this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.btnMinimize.ForeColor = System.Drawing.Color.White;
		this.btnMinimize.Image = (System.Drawing.Image)resources.GetObject("btnMinimize.Image");
		this.btnMinimize.Location = new System.Drawing.Point(320, 0);
		this.btnMinimize.Name = "btnMinimize";
		this.btnMinimize.Size = new System.Drawing.Size(32, 28);
		this.btnMinimize.TabIndex = 9;
		this.btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.btnMinimize.UseVisualStyleBackColor = true;
		this.btnMinimize.Click += new System.EventHandler(btnMinimize_Click);
		this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		this.bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		this.bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		this.bunifuCustomLabel1.Size = new System.Drawing.Size(352, 28);
		this.bunifuCustomLabel1.TabIndex = 1;
		this.bunifuCustomLabel1.Text = "Tùy chọn mật khẩu";
		this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.btnCancel.BackColor = System.Drawing.Color.Maroon;
		this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnCancel.FlatAppearance.BorderSize = 0;
		this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnCancel.ForeColor = System.Drawing.Color.White;
		this.btnCancel.Location = new System.Drawing.Point(186, 191);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new System.Drawing.Size(92, 29);
		this.btnCancel.TabIndex = 4;
		this.btnCancel.Text = "Đo\u0301ng";
		this.btnCancel.UseVisualStyleBackColor = false;
		this.btnCancel.Click += new System.EventHandler(btnCancel_Click);
		this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnAdd.FlatAppearance.BorderSize = 0;
		this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnAdd.ForeColor = System.Drawing.Color.White;
		this.btnAdd.Location = new System.Drawing.Point(82, 191);
		this.btnAdd.Name = "btnAdd";
		this.btnAdd.Size = new System.Drawing.Size(92, 29);
		this.btnAdd.TabIndex = 3;
		this.btnAdd.Text = "Lưu";
		this.btnAdd.UseVisualStyleBackColor = false;
		this.btnAdd.Click += new System.EventHandler(btnAdd_Click);
		this.bunifuDragControl_0.Fixed = true;
		this.bunifuDragControl_0.Horizontal = true;
		this.bunifuDragControl_0.TargetControl = this.bunifuCustomLabel1;
		this.bunifuDragControl_0.Vertical = true;
		this.label1.AutoSize = true;
		this.label1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label1.Location = new System.Drawing.Point(12, 53);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(99, 16);
		this.label1.TabIndex = 5;
		this.label1.Text = "Cấu hình đổi IP:";
		this.label2.AutoSize = true;
		this.label2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label2.Location = new System.Drawing.Point(12, 95);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(65, 16);
		this.label2.TabIndex = 6;
		this.label2.Text = "Tùy chọn:";
		this.rbXuatAll.AutoSize = true;
		this.rbXuatAll.Checked = true;
		this.rbXuatAll.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbXuatAll.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.rbXuatAll.Location = new System.Drawing.Point(129, 93);
		this.rbXuatAll.Name = "rbXuatAll";
		this.rbXuatAll.Size = new System.Drawing.Size(124, 20);
		this.rbXuatAll.TabIndex = 8;
		this.rbXuatAll.TabStop = true;
		this.rbXuatAll.Text = "Xuất tất cả nhóm";
		this.rbXuatAll.UseVisualStyleBackColor = true;
		this.rbXuatNhomKiemDuyet.AutoSize = true;
		this.rbXuatNhomKiemDuyet.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbXuatNhomKiemDuyet.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.rbXuatNhomKiemDuyet.Location = new System.Drawing.Point(129, 119);
		this.rbXuatNhomKiemDuyet.Name = "rbXuatNhomKiemDuyet";
		this.rbXuatNhomKiemDuyet.Size = new System.Drawing.Size(174, 20);
		this.rbXuatNhomKiemDuyet.TabIndex = 9;
		this.rbXuatNhomKiemDuyet.Text = "Chỉ xuất nhóm kiểm duyệt";
		this.rbXuatNhomKiemDuyet.UseVisualStyleBackColor = true;
		this.rbXuatNhomKhongKiemDuyet.AutoSize = true;
		this.rbXuatNhomKhongKiemDuyet.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbXuatNhomKhongKiemDuyet.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.rbXuatNhomKhongKiemDuyet.Location = new System.Drawing.Point(129, 145);
		this.rbXuatNhomKhongKiemDuyet.Name = "rbXuatNhomKhongKiemDuyet";
		this.rbXuatNhomKhongKiemDuyet.Size = new System.Drawing.Size(212, 20);
		this.rbXuatNhomKhongKiemDuyet.TabIndex = 10;
		this.rbXuatNhomKhongKiemDuyet.Text = "Chỉ xuất nhóm không kiểm duyệt";
		this.rbXuatNhomKhongKiemDuyet.UseVisualStyleBackColor = true;
		this.metroButton1.Location = new System.Drawing.Point(129, 49);
		this.metroButton1.Name = "metroButton1";
		this.metroButton1.Size = new System.Drawing.Size(75, 23);
		this.metroButton1.TabIndex = 11;
		this.metroButton1.Text = "Cấu hình";
		this.metroButton1.UseSelectable = true;
		this.metroButton1.Click += new System.EventHandler(metroButton1_Click);
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(354, 228);
		base.Controls.Add(this.metroButton1);
		base.Controls.Add(this.rbXuatNhomKhongKiemDuyet);
		base.Controls.Add(this.rbXuatNhomKiemDuyet);
		base.Controls.Add(this.rbXuatAll);
		base.Controls.Add(this.label2);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.btnCancel);
		base.Controls.Add(this.btnAdd);
		base.Controls.Add(this.bunifuCards1);
		this.Cursor = System.Windows.Forms.Cursors.Hand;
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fCauHinhQuetNhom";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "fAddFile";
		base.Load += new System.EventHandler(fCauHinhQuetNhom_Load);
		this.bunifuCards1.ResumeLayout(false);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
