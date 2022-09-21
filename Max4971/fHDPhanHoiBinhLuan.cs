using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDPhanHoiBinhLuan : Form
{
	private GClass17 gclass17_0;

	private string string_0;

	private string string_1;

	private string string_2;

	private int int_0;

	public static bool bool_0;

	private IContainer icontainer_0 = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl bunifuDragControl_1;

	private Panel panel1;

	private NumericUpDown nudDelayTo;

	private NumericUpDown nudDelayFrom;

	private TextBox txtTenHanhDong;

	private Label label7;

	private Label label6;

	private Label label5;

	private Label label1;

	private Button btnCancel;

	private Button btnAdd;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private Button button1;

	private PictureBox pictureBox1;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Label label10;

	private Label label2;

	private CheckBox ckbCommentImage;

	private NumericUpDown nudSoLuongTo;

	private NumericUpDown nudSoLuongFrom;

	private Label label3;

	private Label label4;

	private Label label8;

	private TextBox txtPath;

	private CheckBox ckbCommentText;

	private Panel panel2;

	private Label lblComment;

	private Label label9;

	private RichTextBox txtUid;

	private RichTextBox txtComment;

	private LinkLabel linkLabel1;

	private NumericUpDown nudSoLuongIdTo;

	private NumericUpDown nudSoLuongIdFrom;

	private Label label11;

	private Label label12;

	private Label label13;

	private CheckBox ckbLike;

	public fHDPhanHoiBinhLuan(string string_3, int int_1 = 0, string string_4 = "")
	{
		InitializeComponent();
		method_0();
		bool_0 = false;
		string_0 = string_3;
		string_2 = string_4;
		int_0 = int_1;
		string text = base.Name.Substring(1);
		string text2 = "Phản hồi bình luận";
		if (Class307.smethod_13("", text).Rows.Count == 0)
		{
			GClass32.GClass32_0.method_2("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\",\"MoTa\") VALUES ('" + text + "', '" + text2 + "');");
		}
		string text3 = "";
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = Class307.smethod_13("", text);
			text3 = dataTable2.Rows[0]["CauHinh"].ToString();
			string_1 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = GClass29.smethod_0(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class307.smethod_15(string_4);
			text3 = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = GClass29.smethod_0("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		gclass17_0 = new GClass17(text3, bool_0: true);
	}

	private void method_0()
	{
		GClass29.smethod_1(bunifuCustomLabel1);
		GClass29.smethod_1(label1);
		GClass29.smethod_1(label5);
		GClass29.smethod_1(label7);
		GClass29.smethod_1(label6);
		GClass29.smethod_1(label2);
		GClass29.smethod_1(label10);
		GClass29.smethod_1(btnAdd);
		GClass29.smethod_1(btnCancel);
	}

	private void fHDPhanHoiBinhLuan_Load(object sender, EventArgs e)
	{
		try
		{
			nudSoLuongIdFrom.Value = gclass17_0.method_2("nudSoLuongIdFrom", 1);
			nudSoLuongIdTo.Value = gclass17_0.method_2("nudSoLuongIdTo", 3);
			nudSoLuongFrom.Value = gclass17_0.method_2("nudSoLuongFrom", 1);
			nudSoLuongTo.Value = gclass17_0.method_2("nudSoLuongTo", 3);
			nudDelayFrom.Value = gclass17_0.method_2("nudDelayFrom", 3);
			nudDelayTo.Value = gclass17_0.method_2("nudDelayTo", 5);
			ckbCommentImage.Checked = gclass17_0.method_3("ckbCommentImage");
			txtPath.Text = gclass17_0.method_0("txtPath");
			ckbCommentText.Checked = gclass17_0.method_3("ckbCommentText");
			txtComment.Text = gclass17_0.method_0("txtComment");
			txtUid.Text = gclass17_0.method_0("txtUid");
			ckbLike.Checked = gclass17_0.method_3("ckbLike");
		}
		catch
		{
		}
		method_1();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			GClass38.smethod_0(GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!"), 3);
			return;
		}
		List<string> list_ = txtUid.Lines.ToList();
		list_ = GClass14.smethod_36(list_);
		if (list_.Count == 0)
		{
			GClass38.smethod_0(GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p danh sa\u0301ch Uid ca\u0301 nhân!"), 3);
			return;
		}
		GClass17 gClass = new GClass17();
		gClass.method_5("nudSoLuongIdFrom", nudSoLuongIdFrom.Value);
		gClass.method_5("nudSoLuongIdTo", nudSoLuongIdTo.Value);
		gClass.method_5("nudSoLuongFrom", nudSoLuongFrom.Value);
		gClass.method_5("nudSoLuongTo", nudSoLuongTo.Value);
		gClass.method_5("nudDelayFrom", nudDelayFrom.Value);
		gClass.method_5("nudDelayTo", nudDelayTo.Value);
		gClass.method_5("ckbCommentImage", ckbCommentImage.Checked);
		gClass.method_5("txtPath", txtPath.Text);
		gClass.method_5("ckbCommentText", ckbCommentText.Checked);
		gClass.method_5("txtComment", txtComment.Text);
		gClass.method_5("txtUid", txtUid.Text.Trim());
		gClass.method_5("ckbLike", ckbLike.Checked);
		string string_ = gClass.method_9();
		if (int_0 == 0)
		{
			if (GClass38.smethod_1(GClass29.smethod_0("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?")) == DialogResult.Yes)
			{
				if (Class307.smethod_18(string_0, text, string_1, string_))
				{
					bool_0 = true;
					Close();
				}
				else
				{
					GClass38.smethod_0(GClass29.smethod_0("Thêm thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!"), 2);
				}
			}
		}
		else if (GClass38.smethod_1(GClass29.smethod_0("Ba\u0323n co\u0301 muô\u0301n câ\u0323p nhâ\u0323t ha\u0300nh đô\u0323ng?")) == DialogResult.Yes)
		{
			if (Class307.smethod_20(string_2, text, string_))
			{
				bool_0 = true;
				Close();
			}
			else
			{
				GClass38.smethod_0(GClass29.smethod_0("Câ\u0323p nhâ\u0323t thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!"), 2);
			}
		}
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void panel1_Paint(object sender, PaintEventArgs e)
	{
		if (panel1.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, panel1.ClientSize.Width - num, panel1.ClientSize.Height - num));
		}
	}

	private void method_1()
	{
		ckbCommentImage_CheckedChanged(null, null);
		ckbCommentText_CheckedChanged(null, null);
	}

	private void txtUid_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> list_ = txtUid.Lines.ToList();
			list_ = GClass14.smethod_36(list_);
			label2.Text = string.Format(GClass29.smethod_0("Danh sa\u0301ch ID Comment ({0}):"), list_.Count.ToString());
		}
		catch
		{
		}
	}

	private void txtComment_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> list_ = txtComment.Lines.ToList();
			list_ = GClass14.smethod_36(list_);
			lblComment.Text = string.Format(GClass29.smethod_0("Danh sa\u0301ch comment ({0}):"), list_.Count.ToString());
		}
		catch
		{
		}
	}

	private void ckbCommentImage_CheckedChanged(object sender, EventArgs e)
	{
		txtPath.Enabled = ckbCommentImage.Checked;
	}

	private void ckbCommentText_CheckedChanged(object sender, EventArgs e)
	{
		panel2.Enabled = ckbCommentText.Checked;
	}

	private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		GClass14.smethod_33(new fHuongDanRandom());
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
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.button1 = new System.Windows.Forms.Button();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.panel1 = new System.Windows.Forms.Panel();
		this.ckbLike = new System.Windows.Forms.CheckBox();
		this.nudSoLuongIdTo = new System.Windows.Forms.NumericUpDown();
		this.nudSoLuongIdFrom = new System.Windows.Forms.NumericUpDown();
		this.label11 = new System.Windows.Forms.Label();
		this.label12 = new System.Windows.Forms.Label();
		this.label13 = new System.Windows.Forms.Label();
		this.txtUid = new System.Windows.Forms.RichTextBox();
		this.panel2 = new System.Windows.Forms.Panel();
		this.linkLabel1 = new System.Windows.Forms.LinkLabel();
		this.txtComment = new System.Windows.Forms.RichTextBox();
		this.lblComment = new System.Windows.Forms.Label();
		this.label9 = new System.Windows.Forms.Label();
		this.txtPath = new System.Windows.Forms.TextBox();
		this.ckbCommentText = new System.Windows.Forms.CheckBox();
		this.ckbCommentImage = new System.Windows.Forms.CheckBox();
		this.nudSoLuongTo = new System.Windows.Forms.NumericUpDown();
		this.nudSoLuongFrom = new System.Windows.Forms.NumericUpDown();
		this.label3 = new System.Windows.Forms.Label();
		this.label4 = new System.Windows.Forms.Label();
		this.label8 = new System.Windows.Forms.Label();
		this.label10 = new System.Windows.Forms.Label();
		this.label2 = new System.Windows.Forms.Label();
		this.nudDelayTo = new System.Windows.Forms.NumericUpDown();
		this.nudDelayFrom = new System.Windows.Forms.NumericUpDown();
		this.txtTenHanhDong = new System.Windows.Forms.TextBox();
		this.label7 = new System.Windows.Forms.Label();
		this.label6 = new System.Windows.Forms.Label();
		this.label5 = new System.Windows.Forms.Label();
		this.label1 = new System.Windows.Forms.Label();
		this.btnCancel = new System.Windows.Forms.Button();
		this.btnAdd = new System.Windows.Forms.Button();
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		this.panel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongIdTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongIdFrom).BeginInit();
		this.panel2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayFrom).BeginInit();
		this.bunifuCards1.SuspendLayout();
		base.SuspendLayout();
		this.bunifuDragControl_0.Fixed = true;
		this.bunifuDragControl_0.Horizontal = true;
		this.bunifuDragControl_0.TargetControl = this.bunifuCustomLabel1;
		this.bunifuDragControl_0.Vertical = true;
		this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		this.bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		this.bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		this.bunifuCustomLabel1.Size = new System.Drawing.Size(739, 31);
		this.bunifuCustomLabel1.TabIndex = 12;
		this.bunifuCustomLabel1.Text = "Cấu hình Phản hồi bình luận";
		this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.bunifuDragControl_1.Fixed = true;
		this.bunifuDragControl_1.Horizontal = true;
		this.bunifuDragControl_1.TargetControl = this.pnlHeader;
		this.bunifuDragControl_1.Vertical = true;
		this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.pnlHeader.BackColor = System.Drawing.Color.White;
		this.pnlHeader.Controls.Add(this.button1);
		this.pnlHeader.Controls.Add(this.pictureBox1);
		this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
		this.pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.pnlHeader.Location = new System.Drawing.Point(0, 3);
		this.pnlHeader.Name = "pnlHeader";
		this.pnlHeader.Size = new System.Drawing.Size(739, 31);
		this.pnlHeader.TabIndex = 9;
		this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button1.FlatAppearance.BorderSize = 0;
		this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.button1.ForeColor = System.Drawing.Color.White;
		this.button1.Image = Class306.Bitmap_15;
		this.button1.Location = new System.Drawing.Point(708, 1);
		this.button1.Name = "button1";
		this.button1.Size = new System.Drawing.Size(30, 30);
		this.button1.TabIndex = 77;
		this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.button1.UseVisualStyleBackColor = true;
		this.button1.Click += new System.EventHandler(button1_Click);
		this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		this.pictureBox1.Image = Class306.Bitmap_59;
		this.pictureBox1.Location = new System.Drawing.Point(3, 2);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(34, 27);
		this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.pictureBox1.TabIndex = 76;
		this.pictureBox1.TabStop = false;
		this.panel1.BackColor = System.Drawing.Color.White;
		this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel1.Controls.Add(this.ckbLike);
		this.panel1.Controls.Add(this.nudSoLuongIdTo);
		this.panel1.Controls.Add(this.nudSoLuongIdFrom);
		this.panel1.Controls.Add(this.label11);
		this.panel1.Controls.Add(this.label12);
		this.panel1.Controls.Add(this.label13);
		this.panel1.Controls.Add(this.txtUid);
		this.panel1.Controls.Add(this.panel2);
		this.panel1.Controls.Add(this.txtPath);
		this.panel1.Controls.Add(this.ckbCommentText);
		this.panel1.Controls.Add(this.ckbCommentImage);
		this.panel1.Controls.Add(this.nudSoLuongTo);
		this.panel1.Controls.Add(this.nudSoLuongFrom);
		this.panel1.Controls.Add(this.label3);
		this.panel1.Controls.Add(this.label4);
		this.panel1.Controls.Add(this.label8);
		this.panel1.Controls.Add(this.label10);
		this.panel1.Controls.Add(this.label2);
		this.panel1.Controls.Add(this.nudDelayTo);
		this.panel1.Controls.Add(this.nudDelayFrom);
		this.panel1.Controls.Add(this.txtTenHanhDong);
		this.panel1.Controls.Add(this.label7);
		this.panel1.Controls.Add(this.label6);
		this.panel1.Controls.Add(this.label5);
		this.panel1.Controls.Add(this.label1);
		this.panel1.Controls.Add(this.btnCancel);
		this.panel1.Controls.Add(this.btnAdd);
		this.panel1.Controls.Add(this.bunifuCards1);
		this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panel1.Location = new System.Drawing.Point(0, 0);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(742, 589);
		this.panel1.TabIndex = 0;
		this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		this.ckbLike.AutoSize = true;
		this.ckbLike.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbLike.Location = new System.Drawing.Point(16, 198);
		this.ckbLike.Name = "ckbLike";
		this.ckbLike.Size = new System.Drawing.Size(105, 20);
		this.ckbLike.TabIndex = 62;
		this.ckbLike.Text = "Like bình luận";
		this.ckbLike.UseVisualStyleBackColor = true;
		this.nudSoLuongIdTo.Cursor = System.Windows.Forms.Cursors.Hand;
		this.nudSoLuongIdTo.Location = new System.Drawing.Point(242, 78);
		this.nudSoLuongIdTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudSoLuongIdTo.Name = "nudSoLuongIdTo";
		this.nudSoLuongIdTo.Size = new System.Drawing.Size(56, 23);
		this.nudSoLuongIdTo.TabIndex = 58;
		this.nudSoLuongIdFrom.Cursor = System.Windows.Forms.Cursors.Hand;
		this.nudSoLuongIdFrom.Location = new System.Drawing.Point(145, 78);
		this.nudSoLuongIdFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudSoLuongIdFrom.Name = "nudSoLuongIdFrom";
		this.nudSoLuongIdFrom.Size = new System.Drawing.Size(56, 23);
		this.nudSoLuongIdFrom.TabIndex = 57;
		this.label11.Location = new System.Drawing.Point(207, 80);
		this.label11.Name = "label11";
		this.label11.Size = new System.Drawing.Size(29, 16);
		this.label11.TabIndex = 61;
		this.label11.Text = "đê\u0301n";
		this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label12.AutoSize = true;
		this.label12.Location = new System.Drawing.Point(300, 80);
		this.label12.Name = "label12";
		this.label12.Size = new System.Drawing.Size(20, 16);
		this.label12.TabIndex = 60;
		this.label12.Text = "ID";
		this.label13.AutoSize = true;
		this.label13.Location = new System.Drawing.Point(12, 80);
		this.label13.Name = "label13";
		this.label13.Size = new System.Drawing.Size(80, 16);
		this.label13.TabIndex = 59;
		this.label13.Text = "Số lượng ID:";
		this.txtUid.Location = new System.Drawing.Point(426, 103);
		this.txtUid.Name = "txtUid";
		this.txtUid.Size = new System.Drawing.Size(302, 366);
		this.txtUid.TabIndex = 56;
		this.txtUid.Text = "";
		this.txtUid.TextChanged += new System.EventHandler(txtUid_TextChanged);
		this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel2.Controls.Add(this.linkLabel1);
		this.panel2.Controls.Add(this.txtComment);
		this.panel2.Controls.Add(this.lblComment);
		this.panel2.Controls.Add(this.label9);
		this.panel2.Location = new System.Drawing.Point(27, 251);
		this.panel2.Name = "panel2";
		this.panel2.Size = new System.Drawing.Size(363, 262);
		this.panel2.TabIndex = 54;
		this.linkLabel1.AutoSize = true;
		this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.linkLabel1.Location = new System.Drawing.Point(271, 236);
		this.linkLabel1.Name = "linkLabel1";
		this.linkLabel1.Size = new System.Drawing.Size(82, 16);
		this.linkLabel1.TabIndex = 191;
		this.linkLabel1.TabStop = true;
		this.linkLabel1.Text = "Random icon";
		this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
		this.txtComment.Location = new System.Drawing.Point(7, 23);
		this.txtComment.Name = "txtComment";
		this.txtComment.Size = new System.Drawing.Size(346, 210);
		this.txtComment.TabIndex = 55;
		this.txtComment.Text = "";
		this.txtComment.TextChanged += new System.EventHandler(txtComment_TextChanged);
		this.lblComment.AutoSize = true;
		this.lblComment.Location = new System.Drawing.Point(4, 4);
		this.lblComment.Name = "lblComment";
		this.lblComment.Size = new System.Drawing.Size(150, 16);
		this.lblComment.TabIndex = 53;
		this.lblComment.Text = "Danh sa\u0301ch comment (0):";
		this.label9.AutoSize = true;
		this.label9.Location = new System.Drawing.Point(9, 236);
		this.label9.Name = "label9";
		this.label9.Size = new System.Drawing.Size(238, 16);
		this.label9.TabIndex = 52;
		this.label9.Text = "(Mỗi nội dung 1 dòng, spin text {a|b|c})";
		this.txtPath.Location = new System.Drawing.Point(146, 168);
		this.txtPath.Name = "txtPath";
		this.txtPath.Size = new System.Drawing.Size(235, 23);
		this.txtPath.TabIndex = 50;
		this.ckbCommentText.AutoSize = true;
		this.ckbCommentText.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbCommentText.Location = new System.Drawing.Point(16, 226);
		this.ckbCommentText.Name = "ckbCommentText";
		this.ckbCommentText.Size = new System.Drawing.Size(128, 20);
		this.ckbCommentText.TabIndex = 49;
		this.ckbCommentText.Text = "Bình luận văn bản";
		this.ckbCommentText.UseVisualStyleBackColor = true;
		this.ckbCommentText.CheckedChanged += new System.EventHandler(ckbCommentText_CheckedChanged);
		this.ckbCommentImage.AutoSize = true;
		this.ckbCommentImage.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbCommentImage.Location = new System.Drawing.Point(16, 170);
		this.ckbCommentImage.Name = "ckbCommentImage";
		this.ckbCommentImage.Size = new System.Drawing.Size(104, 20);
		this.ckbCommentImage.TabIndex = 48;
		this.ckbCommentImage.Text = "Bình luận ảnh";
		this.ckbCommentImage.UseVisualStyleBackColor = true;
		this.ckbCommentImage.CheckedChanged += new System.EventHandler(ckbCommentImage_CheckedChanged);
		this.nudSoLuongTo.Cursor = System.Windows.Forms.Cursors.Hand;
		this.nudSoLuongTo.Location = new System.Drawing.Point(243, 107);
		this.nudSoLuongTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudSoLuongTo.Name = "nudSoLuongTo";
		this.nudSoLuongTo.Size = new System.Drawing.Size(56, 23);
		this.nudSoLuongTo.TabIndex = 43;
		this.nudSoLuongFrom.Cursor = System.Windows.Forms.Cursors.Hand;
		this.nudSoLuongFrom.Location = new System.Drawing.Point(146, 107);
		this.nudSoLuongFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudSoLuongFrom.Name = "nudSoLuongFrom";
		this.nudSoLuongFrom.Size = new System.Drawing.Size(56, 23);
		this.nudSoLuongFrom.TabIndex = 42;
		this.label3.Location = new System.Drawing.Point(208, 109);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(29, 16);
		this.label3.TabIndex = 46;
		this.label3.Text = "đê\u0301n";
		this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label4.AutoSize = true;
		this.label4.Location = new System.Drawing.Point(301, 109);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(61, 16);
		this.label4.TabIndex = 45;
		this.label4.Text = "comment";
		this.label8.AutoSize = true;
		this.label8.Location = new System.Drawing.Point(13, 109);
		this.label8.Name = "label8";
		this.label8.Size = new System.Drawing.Size(102, 16);
		this.label8.TabIndex = 44;
		this.label8.Text = "Số comment/ID:";
		this.label10.AutoSize = true;
		this.label10.Location = new System.Drawing.Point(423, 472);
		this.label10.Name = "label10";
		this.label10.Size = new System.Drawing.Size(125, 16);
		this.label10.TabIndex = 39;
		this.label10.Text = "(Mỗi ID Post 1 dòng)";
		this.label2.AutoSize = true;
		this.label2.Location = new System.Drawing.Point(421, 84);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(137, 16);
		this.label2.TabIndex = 40;
		this.label2.Text = "Danh sa\u0301ch ID Post (0):";
		this.nudDelayTo.Cursor = System.Windows.Forms.Cursors.Hand;
		this.nudDelayTo.Location = new System.Drawing.Point(243, 136);
		this.nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudDelayTo.Name = "nudDelayTo";
		this.nudDelayTo.Size = new System.Drawing.Size(56, 23);
		this.nudDelayTo.TabIndex = 4;
		this.nudDelayFrom.Cursor = System.Windows.Forms.Cursors.Hand;
		this.nudDelayFrom.Location = new System.Drawing.Point(146, 136);
		this.nudDelayFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudDelayFrom.Name = "nudDelayFrom";
		this.nudDelayFrom.Size = new System.Drawing.Size(56, 23);
		this.nudDelayFrom.TabIndex = 3;
		this.txtTenHanhDong.Location = new System.Drawing.Point(146, 49);
		this.txtTenHanhDong.Name = "txtTenHanhDong";
		this.txtTenHanhDong.Size = new System.Drawing.Size(216, 23);
		this.txtTenHanhDong.TabIndex = 0;
		this.label7.Location = new System.Drawing.Point(208, 138);
		this.label7.Name = "label7";
		this.label7.Size = new System.Drawing.Size(29, 16);
		this.label7.TabIndex = 38;
		this.label7.Text = "đê\u0301n";
		this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label6.AutoSize = true;
		this.label6.Location = new System.Drawing.Point(301, 138);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(31, 16);
		this.label6.TabIndex = 36;
		this.label6.Text = "giây";
		this.label5.AutoSize = true;
		this.label5.Location = new System.Drawing.Point(13, 138);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(100, 16);
		this.label5.TabIndex = 34;
		this.label5.Text = "Thơ\u0300i gian delay:";
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(11, 52);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(99, 16);
		this.label1.TabIndex = 31;
		this.label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.btnCancel.BackColor = System.Drawing.Color.Maroon;
		this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnCancel.FlatAppearance.BorderSize = 0;
		this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnCancel.ForeColor = System.Drawing.Color.White;
		this.btnCancel.Location = new System.Drawing.Point(378, 547);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new System.Drawing.Size(92, 29);
		this.btnCancel.TabIndex = 10;
		this.btnCancel.Text = "Đóng";
		this.btnCancel.UseVisualStyleBackColor = false;
		this.btnCancel.Click += new System.EventHandler(btnCancel_Click);
		this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnAdd.FlatAppearance.BorderSize = 0;
		this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnAdd.ForeColor = System.Drawing.Color.White;
		this.btnAdd.Location = new System.Drawing.Point(271, 547);
		this.btnAdd.Name = "btnAdd";
		this.btnAdd.Size = new System.Drawing.Size(92, 29);
		this.btnAdd.TabIndex = 9;
		this.btnAdd.Text = "Thêm";
		this.btnAdd.UseVisualStyleBackColor = false;
		this.btnAdd.Click += new System.EventHandler(btnAdd_Click);
		this.bunifuCards1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.bunifuCards1.BackColor = System.Drawing.Color.White;
		this.bunifuCards1.BorderRadius = 0;
		this.bunifuCards1.BottomSahddow = true;
		this.bunifuCards1.color = System.Drawing.Color.DarkViolet;
		this.bunifuCards1.Controls.Add(this.pnlHeader);
		this.bunifuCards1.LeftSahddow = false;
		this.bunifuCards1.Location = new System.Drawing.Point(1, 0);
		this.bunifuCards1.Name = "bunifuCards1";
		this.bunifuCards1.RightSahddow = true;
		this.bunifuCards1.ShadowDepth = 20;
		this.bunifuCards1.Size = new System.Drawing.Size(739, 37);
		this.bunifuCards1.TabIndex = 28;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(742, 589);
		base.Controls.Add(this.panel1);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDPhanHoiBinhLuan";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDPhanHoiBinhLuan_Load);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongIdTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongIdFrom).EndInit();
		this.panel2.ResumeLayout(false);
		this.panel2.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayFrom).EndInit();
		this.bunifuCards1.ResumeLayout(false);
		base.ResumeLayout(false);
	}
}