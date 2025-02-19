using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Newtonsoft.Json.Linq;

public class fHDRoiNhom : Form
{
	private JObject jobject_0;

	private string string_0;

	private string string_1;

	private string string_2;

	private int int_0;

	public static bool bool_0;

	private IContainer icontainer_0 = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl bunifuDragControl_1;

	private Panel panel1;

	private NumericUpDown nudSoLuongTo;

	private NumericUpDown nudSoLuongFrom;

	private TextBox txtTenHanhDong;

	private Label label3;

	private Label label4;

	private Label label2;

	private Label label1;

	private Button btnCancel;

	private Button btnAdd;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private Button button1;

	private PictureBox pictureBox1;

	private BunifuCustomLabel bunifuCustomLabel1;

	private NumericUpDown nudDelayTo;

	private NumericUpDown nudDelayFrom;

	private Label label7;

	private Label label6;

	private Label label5;

	private RadioButton rbRoiTheoDieuKien;

	private RadioButton rbNgauNhien;

	private Label label9;

	private Panel plUidChiDinh;

	private TextBox txtTuKhoa;

	private Label label10;

	private Label lblStatusUid;

	private Panel plDieuKienTuKhoa;

	private CheckBox ckbDieuKienTuKhoa;

	private CheckBox ckbDieuKienThanhVien;

	private NumericUpDown nudThanhVienToiDa;

	private Label label12;

	private RichTextBox txtIDNhomGiuLai;

	private Label label8;

	private RadioButton rbNhomKiemDuyet;

	private Panel panel2;

	private Label label11;

	private Label label13;

	private TextBox txtIdNhomRoi;

	private CheckBox ckbDieuKienID;

	public fHDRoiNhom(string string_3, int int_1 = 0, string string_4 = "")
	{
		InitializeComponent();
		method_0();
		bool_0 = false;
		string_0 = string_3;
		string_2 = string_4;
		int_0 = int_1;
		string json = "";
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = Class307.smethod_13("", "HDRoiNhom");
			json = dataTable2.Rows[0]["CauHinh"].ToString();
			string_1 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = GClass29.smethod_0(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class307.smethod_15(string_4);
			json = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = GClass29.smethod_0("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		jobject_0 = JObject.Parse(json);
	}

	private void method_0()
	{
		GClass29.smethod_1(bunifuCustomLabel1);
		GClass29.smethod_1(label1);
		GClass29.smethod_1(label2);
		GClass29.smethod_1(label3);
		GClass29.smethod_1(label4);
		GClass29.smethod_1(label5);
		GClass29.smethod_1(label7);
		GClass29.smethod_1(label6);
		GClass29.smethod_1(label9);
		GClass29.smethod_1(rbNgauNhien);
		GClass29.smethod_1(rbNhomKiemDuyet);
		GClass29.smethod_1(rbRoiTheoDieuKien);
		GClass29.smethod_1(ckbDieuKienThanhVien);
		GClass29.smethod_1(ckbDieuKienTuKhoa);
		GClass29.smethod_1(lblStatusUid);
		GClass29.smethod_1(label10);
		GClass29.smethod_1(label8);
		GClass29.smethod_1(label12);
		GClass29.smethod_1(btnAdd);
		GClass29.smethod_1(btnCancel);
	}

	private void fHDRoiNhom_Load(object sender, EventArgs e)
	{
		try
		{
			nudSoLuongFrom.Value = Convert.ToInt32(jobject_0["nudSoLuongFrom"]);
			nudSoLuongTo.Value = Convert.ToInt32(jobject_0["nudSoLuongTo"]);
			nudDelayFrom.Value = Convert.ToInt32(jobject_0["nudDelayFrom"]);
			nudDelayTo.Value = Convert.ToInt32(jobject_0["nudDelayTo"]);
			if (Convert.ToInt32(jobject_0["typeRoiNhom"]) == 0)
			{
				rbNgauNhien.Checked = true;
			}
			else if (Convert.ToInt32(jobject_0["typeRoiNhom"]) == 1)
			{
				rbNhomKiemDuyet.Checked = true;
			}
			else
			{
				rbRoiTheoDieuKien.Checked = true;
			}
			ckbDieuKienThanhVien.Checked = Convert.ToBoolean(jobject_0["ckbDieuKienThanhVien"]);
			nudThanhVienToiDa.Value = Convert.ToInt32(jobject_0["nudThanhVienToiDa"]);
			ckbDieuKienTuKhoa.Checked = Convert.ToBoolean(jobject_0["ckbDieuKienTuKhoa"]);
			txtTuKhoa.Text = jobject_0["txtTuKhoa"]!.ToString();
			txtIDNhomGiuLai.Text = jobject_0["txtIDNhomGiuLai"]!.ToString();
			ckbDieuKienID.Checked = Convert.ToBoolean(jobject_0["ckbDieuKienID"]);
			txtIdNhomRoi.Text = jobject_0["txtIdNhomRoi"]!.ToString();
		}
		catch
		{
		}
		method_2();
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
		if (rbRoiTheoDieuKien.Checked)
		{
			if (!ckbDieuKienThanhVien.Checked && !ckbDieuKienTuKhoa.Checked && !ckbDieuKienID.Checked)
			{
				GClass38.smethod_0(GClass29.smethod_0("Vui lo\u0300ng cho\u0323n i\u0301t nhâ\u0301t mô\u0323t điê\u0300u kiê\u0323n rơ\u0300i nho\u0301m!"), 3);
				return;
			}
			if (ckbDieuKienTuKhoa.Checked)
			{
				List<string> list_ = txtTuKhoa.Lines.ToList();
				list_ = GClass14.smethod_36(list_);
				if (list_.Count == 0)
				{
					GClass38.smethod_0(GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p danh sa\u0301ch tư\u0300 kho\u0301a!"), 3);
					return;
				}
			}
			else if (ckbDieuKienID.Checked)
			{
				List<string> list_2 = txtIdNhomRoi.Lines.ToList();
				list_2 = GClass14.smethod_36(list_2);
				if (list_2.Count == 0)
				{
					GClass38.smethod_0(GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p danh sa\u0301ch nhóm cần rời!"), 3);
					return;
				}
			}
		}
		GClass17 gClass = new GClass17();
		gClass.method_5("nudSoLuongFrom", nudSoLuongFrom.Value);
		gClass.method_5("nudSoLuongTo", nudSoLuongTo.Value);
		gClass.method_5("nudDelayFrom", nudDelayFrom.Value);
		gClass.method_5("nudDelayTo", nudDelayTo.Value);
		if (rbNgauNhien.Checked)
		{
			gClass.method_5("typeRoiNhom", 0);
		}
		else if (rbNhomKiemDuyet.Checked)
		{
			gClass.method_5("typeRoiNhom", 1);
		}
		else
		{
			gClass.method_5("typeRoiNhom", 2);
		}
		gClass.method_5("ckbDieuKienThanhVien", ckbDieuKienThanhVien.Checked);
		gClass.method_5("nudThanhVienToiDa", nudThanhVienToiDa.Value);
		gClass.method_5("ckbDieuKienTuKhoa", ckbDieuKienTuKhoa.Checked);
		gClass.method_5("txtTuKhoa", txtTuKhoa.Text.Trim());
		gClass.method_5("txtIDNhomGiuLai", txtIDNhomGiuLai.Text);
		gClass.method_5("ckbDieuKienID", ckbDieuKienID.Checked);
		gClass.method_5("txtIdNhomRoi", txtIdNhomRoi.Text.Trim());
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

	private void rbRoiTheoDieuKien_CheckedChanged(object sender, EventArgs e)
	{
		method_1();
	}

	private void method_1()
	{
		plUidChiDinh.Enabled = rbRoiTheoDieuKien.Checked;
	}

	private void txtTuKhoa_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> list_ = txtTuKhoa.Lines.ToList();
			list_ = GClass14.smethod_36(list_);
			lblStatusUid.Text = string.Format(GClass29.smethod_0("Danh sách tư\u0300 kho\u0301a ({0}):"), list_.Count.ToString());
		}
		catch
		{
		}
	}

	private void method_2()
	{
		ckbDieuKienThanhVien_CheckedChanged(null, null);
		ckbDieuKienTuKhoa_CheckedChanged(null, null);
		method_1();
		txtIdNhomRoi_TextChanged(null, null);
		ckbDieuKienID_CheckedChanged(null, null);
	}

	private void ckbDieuKienThanhVien_CheckedChanged(object sender, EventArgs e)
	{
		nudThanhVienToiDa.Enabled = ckbDieuKienThanhVien.Checked;
	}

	private void ckbDieuKienTuKhoa_CheckedChanged(object sender, EventArgs e)
	{
		plDieuKienTuKhoa.Enabled = ckbDieuKienTuKhoa.Checked;
	}

	private void label8_Click(object sender, EventArgs e)
	{
	}

	private void txtIDNhomGiuLai_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> list_ = txtIDNhomGiuLai.Lines.ToList();
			list_ = GClass14.smethod_36(list_);
			label8.Text = string.Format(GClass29.smethod_0("Danh sách ID nhóm cần giữ lại ({0}):"), list_.Count);
		}
		catch
		{
		}
	}

	private void label12_Click(object sender, EventArgs e)
	{
	}

	private void txtIdNhomRoi_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> list_ = txtIdNhomRoi.Lines.ToList();
			list_ = GClass14.smethod_36(list_);
			label11.Text = string.Format(GClass29.smethod_0("Danh sách ID nhóm ({0}):"), list_.Count.ToString());
		}
		catch
		{
		}
	}

	private void ckbDieuKienID_CheckedChanged(object sender, EventArgs e)
	{
		panel2.Enabled = ckbDieuKienID.Checked;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDRoiNhom));
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.button1 = new System.Windows.Forms.Button();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.panel1 = new System.Windows.Forms.Panel();
		this.label12 = new System.Windows.Forms.Label();
		this.txtIDNhomGiuLai = new System.Windows.Forms.RichTextBox();
		this.label8 = new System.Windows.Forms.Label();
		this.plUidChiDinh = new System.Windows.Forms.Panel();
		this.panel2 = new System.Windows.Forms.Panel();
		this.label11 = new System.Windows.Forms.Label();
		this.label13 = new System.Windows.Forms.Label();
		this.txtIdNhomRoi = new System.Windows.Forms.TextBox();
		this.ckbDieuKienID = new System.Windows.Forms.CheckBox();
		this.plDieuKienTuKhoa = new System.Windows.Forms.Panel();
		this.lblStatusUid = new System.Windows.Forms.Label();
		this.label10 = new System.Windows.Forms.Label();
		this.txtTuKhoa = new System.Windows.Forms.TextBox();
		this.ckbDieuKienTuKhoa = new System.Windows.Forms.CheckBox();
		this.ckbDieuKienThanhVien = new System.Windows.Forms.CheckBox();
		this.nudThanhVienToiDa = new System.Windows.Forms.NumericUpDown();
		this.rbRoiTheoDieuKien = new System.Windows.Forms.RadioButton();
		this.rbNhomKiemDuyet = new System.Windows.Forms.RadioButton();
		this.rbNgauNhien = new System.Windows.Forms.RadioButton();
		this.label9 = new System.Windows.Forms.Label();
		this.nudDelayTo = new System.Windows.Forms.NumericUpDown();
		this.nudDelayFrom = new System.Windows.Forms.NumericUpDown();
		this.label7 = new System.Windows.Forms.Label();
		this.label6 = new System.Windows.Forms.Label();
		this.label5 = new System.Windows.Forms.Label();
		this.nudSoLuongTo = new System.Windows.Forms.NumericUpDown();
		this.nudSoLuongFrom = new System.Windows.Forms.NumericUpDown();
		this.txtTenHanhDong = new System.Windows.Forms.TextBox();
		this.label3 = new System.Windows.Forms.Label();
		this.label4 = new System.Windows.Forms.Label();
		this.label2 = new System.Windows.Forms.Label();
		this.label1 = new System.Windows.Forms.Label();
		this.btnCancel = new System.Windows.Forms.Button();
		this.btnAdd = new System.Windows.Forms.Button();
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		this.panel1.SuspendLayout();
		this.plUidChiDinh.SuspendLayout();
		this.panel2.SuspendLayout();
		this.plDieuKienTuKhoa.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudThanhVienToiDa).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongFrom).BeginInit();
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
		this.bunifuCustomLabel1.Size = new System.Drawing.Size(669, 31);
		this.bunifuCustomLabel1.TabIndex = 12;
		this.bunifuCustomLabel1.Text = "Cấu hình Rơ\u0300i nho\u0301m";
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
		this.pnlHeader.Size = new System.Drawing.Size(669, 31);
		this.pnlHeader.TabIndex = 9;
		this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button1.FlatAppearance.BorderSize = 0;
		this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.button1.ForeColor = System.Drawing.Color.White;
		this.button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		this.button1.Location = new System.Drawing.Point(638, 1);
		this.button1.Name = "button1";
		this.button1.Size = new System.Drawing.Size(30, 30);
		this.button1.TabIndex = 77;
		this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.button1.UseVisualStyleBackColor = true;
		this.button1.Click += new System.EventHandler(button1_Click);
		this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		this.pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		this.pictureBox1.Location = new System.Drawing.Point(3, 2);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(34, 27);
		this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.pictureBox1.TabIndex = 76;
		this.pictureBox1.TabStop = false;
		this.panel1.BackColor = System.Drawing.Color.White;
		this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel1.Controls.Add(this.label12);
		this.panel1.Controls.Add(this.txtIDNhomGiuLai);
		this.panel1.Controls.Add(this.label8);
		this.panel1.Controls.Add(this.plUidChiDinh);
		this.panel1.Controls.Add(this.rbRoiTheoDieuKien);
		this.panel1.Controls.Add(this.rbNhomKiemDuyet);
		this.panel1.Controls.Add(this.rbNgauNhien);
		this.panel1.Controls.Add(this.label9);
		this.panel1.Controls.Add(this.nudDelayTo);
		this.panel1.Controls.Add(this.nudDelayFrom);
		this.panel1.Controls.Add(this.label7);
		this.panel1.Controls.Add(this.label6);
		this.panel1.Controls.Add(this.label5);
		this.panel1.Controls.Add(this.nudSoLuongTo);
		this.panel1.Controls.Add(this.nudSoLuongFrom);
		this.panel1.Controls.Add(this.txtTenHanhDong);
		this.panel1.Controls.Add(this.label3);
		this.panel1.Controls.Add(this.label4);
		this.panel1.Controls.Add(this.label2);
		this.panel1.Controls.Add(this.label1);
		this.panel1.Controls.Add(this.btnCancel);
		this.panel1.Controls.Add(this.btnAdd);
		this.panel1.Controls.Add(this.bunifuCards1);
		this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panel1.Location = new System.Drawing.Point(0, 0);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(672, 672);
		this.panel1.TabIndex = 0;
		this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		this.label12.AutoSize = true;
		this.label12.Location = new System.Drawing.Point(30, 585);
		this.label12.Name = "label12";
		this.label12.Size = new System.Drawing.Size(97, 16);
		this.label12.TabIndex = 119;
		this.label12.Text = "(Mỗi ID 1 dòng)";
		this.label12.Click += new System.EventHandler(label12_Click);
		this.txtIDNhomGiuLai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.txtIDNhomGiuLai.Location = new System.Drawing.Point(33, 169);
		this.txtIDNhomGiuLai.Name = "txtIDNhomGiuLai";
		this.txtIDNhomGiuLai.Size = new System.Drawing.Size(253, 413);
		this.txtIDNhomGiuLai.TabIndex = 120;
		this.txtIDNhomGiuLai.Text = "";
		this.txtIDNhomGiuLai.WordWrap = false;
		this.txtIDNhomGiuLai.TextChanged += new System.EventHandler(txtIDNhomGiuLai_TextChanged);
		this.label8.AutoSize = true;
		this.label8.Location = new System.Drawing.Point(30, 150);
		this.label8.Name = "label8";
		this.label8.Size = new System.Drawing.Size(208, 16);
		this.label8.TabIndex = 118;
		this.label8.Text = "Danh sách ID nhóm cần giữ lại (0):";
		this.label8.Click += new System.EventHandler(label8_Click);
		this.plUidChiDinh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plUidChiDinh.Controls.Add(this.panel2);
		this.plUidChiDinh.Controls.Add(this.ckbDieuKienID);
		this.plUidChiDinh.Controls.Add(this.plDieuKienTuKhoa);
		this.plUidChiDinh.Controls.Add(this.ckbDieuKienTuKhoa);
		this.plUidChiDinh.Controls.Add(this.ckbDieuKienThanhVien);
		this.plUidChiDinh.Controls.Add(this.nudThanhVienToiDa);
		this.plUidChiDinh.Location = new System.Drawing.Point(350, 174);
		this.plUidChiDinh.Name = "plUidChiDinh";
		this.plUidChiDinh.Size = new System.Drawing.Size(295, 424);
		this.plUidChiDinh.TabIndex = 49;
		this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel2.Controls.Add(this.label11);
		this.panel2.Controls.Add(this.label13);
		this.panel2.Controls.Add(this.txtIdNhomRoi);
		this.panel2.Location = new System.Drawing.Point(20, 247);
		this.panel2.Name = "panel2";
		this.panel2.Size = new System.Drawing.Size(265, 160);
		this.panel2.TabIndex = 52;
		this.label11.AutoSize = true;
		this.label11.Location = new System.Drawing.Point(3, 3);
		this.label11.Name = "label11";
		this.label11.Size = new System.Drawing.Size(145, 16);
		this.label11.TabIndex = 0;
		this.label11.Text = "Danh sách ID nhóm (0):";
		this.label13.AutoSize = true;
		this.label13.Location = new System.Drawing.Point(4, 139);
		this.label13.Name = "label13";
		this.label13.Size = new System.Drawing.Size(133, 16);
		this.label13.TabIndex = 0;
		this.label13.Text = "(Mỗi ID nhóm 1 dòng)";
		this.txtIdNhomRoi.Location = new System.Drawing.Point(7, 25);
		this.txtIdNhomRoi.Multiline = true;
		this.txtIdNhomRoi.Name = "txtIdNhomRoi";
		this.txtIdNhomRoi.ScrollBars = System.Windows.Forms.ScrollBars.Both;
		this.txtIdNhomRoi.Size = new System.Drawing.Size(253, 111);
		this.txtIdNhomRoi.TabIndex = 1;
		this.txtIdNhomRoi.WordWrap = false;
		this.txtIdNhomRoi.TextChanged += new System.EventHandler(txtIdNhomRoi_TextChanged);
		this.ckbDieuKienID.AutoSize = true;
		this.ckbDieuKienID.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbDieuKienID.Location = new System.Drawing.Point(6, 221);
		this.ckbDieuKienID.Name = "ckbDieuKienID";
		this.ckbDieuKienID.Size = new System.Drawing.Size(126, 20);
		this.ckbDieuKienID.TabIndex = 51;
		this.ckbDieuKienID.Text = "Rời theo ID nhóm";
		this.ckbDieuKienID.UseVisualStyleBackColor = true;
		this.ckbDieuKienID.CheckedChanged += new System.EventHandler(ckbDieuKienID_CheckedChanged);
		this.plDieuKienTuKhoa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plDieuKienTuKhoa.Controls.Add(this.lblStatusUid);
		this.plDieuKienTuKhoa.Controls.Add(this.label10);
		this.plDieuKienTuKhoa.Controls.Add(this.txtTuKhoa);
		this.plDieuKienTuKhoa.Location = new System.Drawing.Point(24, 55);
		this.plDieuKienTuKhoa.Name = "plDieuKienTuKhoa";
		this.plDieuKienTuKhoa.Size = new System.Drawing.Size(265, 160);
		this.plDieuKienTuKhoa.TabIndex = 50;
		this.lblStatusUid.AutoSize = true;
		this.lblStatusUid.Location = new System.Drawing.Point(3, 3);
		this.lblStatusUid.Name = "lblStatusUid";
		this.lblStatusUid.Size = new System.Drawing.Size(140, 16);
		this.lblStatusUid.TabIndex = 0;
		this.lblStatusUid.Text = "Danh sách tư\u0300 kho\u0301a (0):";
		this.label10.AutoSize = true;
		this.label10.Location = new System.Drawing.Point(4, 139);
		this.label10.Name = "label10";
		this.label10.Size = new System.Drawing.Size(128, 16);
		this.label10.TabIndex = 0;
		this.label10.Text = "(Mỗi tư\u0300 kho\u0301a 1 dòng)";
		this.txtTuKhoa.Location = new System.Drawing.Point(7, 25);
		this.txtTuKhoa.Multiline = true;
		this.txtTuKhoa.Name = "txtTuKhoa";
		this.txtTuKhoa.ScrollBars = System.Windows.Forms.ScrollBars.Both;
		this.txtTuKhoa.Size = new System.Drawing.Size(253, 111);
		this.txtTuKhoa.TabIndex = 1;
		this.txtTuKhoa.WordWrap = false;
		this.txtTuKhoa.TextChanged += new System.EventHandler(txtTuKhoa_TextChanged);
		this.ckbDieuKienTuKhoa.AutoSize = true;
		this.ckbDieuKienTuKhoa.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbDieuKienTuKhoa.Location = new System.Drawing.Point(6, 29);
		this.ckbDieuKienTuKhoa.Name = "ckbDieuKienTuKhoa";
		this.ckbDieuKienTuKhoa.Size = new System.Drawing.Size(210, 20);
		this.ckbDieuKienTuKhoa.TabIndex = 2;
		this.ckbDieuKienTuKhoa.Text = "Tên nho\u0301m co\u0301 chư\u0301a tư\u0300 kho\u0301a sau:";
		this.ckbDieuKienTuKhoa.UseVisualStyleBackColor = true;
		this.ckbDieuKienTuKhoa.CheckedChanged += new System.EventHandler(ckbDieuKienTuKhoa_CheckedChanged);
		this.ckbDieuKienThanhVien.AutoSize = true;
		this.ckbDieuKienThanhVien.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbDieuKienThanhVien.Location = new System.Drawing.Point(6, 3);
		this.ckbDieuKienThanhVien.Name = "ckbDieuKienThanhVien";
		this.ckbDieuKienThanhVien.Size = new System.Drawing.Size(182, 20);
		this.ckbDieuKienThanhVien.TabIndex = 2;
		this.ckbDieuKienThanhVien.Text = "Sô\u0301 lươ\u0323ng tha\u0300nh viên i\u0301t hơn:";
		this.ckbDieuKienThanhVien.UseVisualStyleBackColor = true;
		this.ckbDieuKienThanhVien.CheckedChanged += new System.EventHandler(ckbDieuKienThanhVien_CheckedChanged);
		this.nudThanhVienToiDa.Location = new System.Drawing.Point(197, 2);
		this.nudThanhVienToiDa.Maximum = new decimal(new int[4] { 999999999, 0, 0, 0 });
		this.nudThanhVienToiDa.Name = "nudThanhVienToiDa";
		this.nudThanhVienToiDa.Size = new System.Drawing.Size(92, 23);
		this.nudThanhVienToiDa.TabIndex = 1;
		this.rbRoiTheoDieuKien.AutoSize = true;
		this.rbRoiTheoDieuKien.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbRoiTheoDieuKien.Location = new System.Drawing.Point(350, 150);
		this.rbRoiTheoDieuKien.Name = "rbRoiTheoDieuKien";
		this.rbRoiTheoDieuKien.Size = new System.Drawing.Size(164, 20);
		this.rbRoiTheoDieuKien.TabIndex = 48;
		this.rbRoiTheoDieuKien.Text = "Rơ\u0300i nho\u0301m theo điê\u0300u kiê\u0323n";
		this.rbRoiTheoDieuKien.UseVisualStyleBackColor = true;
		this.rbRoiTheoDieuKien.CheckedChanged += new System.EventHandler(rbRoiTheoDieuKien_CheckedChanged);
		this.rbNhomKiemDuyet.AutoSize = true;
		this.rbNhomKiemDuyet.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbNhomKiemDuyet.Location = new System.Drawing.Point(350, 126);
		this.rbNhomKiemDuyet.Name = "rbNhomKiemDuyet";
		this.rbNhomKiemDuyet.Size = new System.Drawing.Size(191, 20);
		this.rbNhomKiemDuyet.TabIndex = 48;
		this.rbNhomKiemDuyet.Text = "Rời nhóm kiểm duyệt bài viết";
		this.rbNhomKiemDuyet.UseVisualStyleBackColor = true;
		this.rbNgauNhien.AutoSize = true;
		this.rbNgauNhien.Checked = true;
		this.rbNgauNhien.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbNgauNhien.Location = new System.Drawing.Point(350, 102);
		this.rbNgauNhien.Name = "rbNgauNhien";
		this.rbNgauNhien.Size = new System.Drawing.Size(188, 20);
		this.rbNgauNhien.TabIndex = 48;
		this.rbNgauNhien.TabStop = true;
		this.rbNgauNhien.Text = "Ngẫu nhiên danh sách nho\u0301m";
		this.rbNgauNhien.UseVisualStyleBackColor = true;
		this.label9.AutoSize = true;
		this.label9.Location = new System.Drawing.Point(347, 80);
		this.label9.Name = "label9";
		this.label9.Size = new System.Drawing.Size(138, 16);
		this.label9.TabIndex = 47;
		this.label9.Text = "Tùy chọn nho\u0301m đê\u0309 rơ\u0300i:";
		this.nudDelayTo.Location = new System.Drawing.Point(229, 111);
		this.nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudDelayTo.Name = "nudDelayTo";
		this.nudDelayTo.Size = new System.Drawing.Size(56, 23);
		this.nudDelayTo.TabIndex = 4;
		this.nudDelayFrom.Location = new System.Drawing.Point(132, 111);
		this.nudDelayFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudDelayFrom.Name = "nudDelayFrom";
		this.nudDelayFrom.Size = new System.Drawing.Size(56, 23);
		this.nudDelayFrom.TabIndex = 3;
		this.label7.Location = new System.Drawing.Point(194, 113);
		this.label7.Name = "label7";
		this.label7.Size = new System.Drawing.Size(29, 16);
		this.label7.TabIndex = 46;
		this.label7.Text = "đê\u0301n";
		this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label6.AutoSize = true;
		this.label6.Location = new System.Drawing.Point(287, 113);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(31, 16);
		this.label6.TabIndex = 45;
		this.label6.Text = "giây";
		this.label5.AutoSize = true;
		this.label5.Location = new System.Drawing.Point(27, 113);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(90, 16);
		this.label5.TabIndex = 44;
		this.label5.Text = "Thơ\u0300i gian chơ\u0300:";
		this.nudSoLuongTo.Location = new System.Drawing.Point(229, 80);
		this.nudSoLuongTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudSoLuongTo.Name = "nudSoLuongTo";
		this.nudSoLuongTo.Size = new System.Drawing.Size(56, 23);
		this.nudSoLuongTo.TabIndex = 2;
		this.nudSoLuongFrom.Location = new System.Drawing.Point(132, 80);
		this.nudSoLuongFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudSoLuongFrom.Name = "nudSoLuongFrom";
		this.nudSoLuongFrom.Size = new System.Drawing.Size(56, 23);
		this.nudSoLuongFrom.TabIndex = 1;
		this.txtTenHanhDong.Location = new System.Drawing.Point(132, 49);
		this.txtTenHanhDong.Name = "txtTenHanhDong";
		this.txtTenHanhDong.Size = new System.Drawing.Size(194, 23);
		this.txtTenHanhDong.TabIndex = 0;
		this.label3.Location = new System.Drawing.Point(194, 82);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(29, 16);
		this.label3.TabIndex = 37;
		this.label3.Text = "đê\u0301n";
		this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label4.AutoSize = true;
		this.label4.Location = new System.Drawing.Point(287, 82);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(40, 16);
		this.label4.TabIndex = 35;
		this.label4.Text = "nho\u0301m";
		this.label2.AutoSize = true;
		this.label2.Location = new System.Drawing.Point(27, 82);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(100, 16);
		this.label2.TabIndex = 32;
		this.label2.Text = "Sô\u0301 lươ\u0323ng nhóm:";
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(27, 52);
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
		this.btnCancel.Location = new System.Drawing.Point(363, 630);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new System.Drawing.Size(92, 29);
		this.btnCancel.TabIndex = 7;
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
		this.btnAdd.Location = new System.Drawing.Point(256, 630);
		this.btnAdd.Name = "btnAdd";
		this.btnAdd.Size = new System.Drawing.Size(92, 29);
		this.btnAdd.TabIndex = 6;
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
		this.bunifuCards1.Size = new System.Drawing.Size(669, 37);
		this.bunifuCards1.TabIndex = 28;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(672, 672);
		base.Controls.Add(this.panel1);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDRoiNhom";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDRoiNhom_Load);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		this.plUidChiDinh.ResumeLayout(false);
		this.plUidChiDinh.PerformLayout();
		this.panel2.ResumeLayout(false);
		this.panel2.PerformLayout();
		this.plDieuKienTuKhoa.ResumeLayout(false);
		this.plDieuKienTuKhoa.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudThanhVienToiDa).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongFrom).EndInit();
		this.bunifuCards1.ResumeLayout(false);
		base.ResumeLayout(false);
	}
}
