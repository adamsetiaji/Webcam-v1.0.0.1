namespace Webcam
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            CaptureBox = new PictureBox();
            groupBox1 = new GroupBox();
            WebCamList = new ComboBox();
            BtnStartCamera = new Button();
            BtnCapture = new Button();
            pictureBox2 = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CaptureBox).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 76.92308F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.0769234F));
            tableLayoutPanel1.Controls.Add(CaptureBox, 0, 1);
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(pictureBox2, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.768116F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 86.23189F));
            tableLayoutPanel1.Size = new Size(859, 415);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // CaptureBox
            // 
            CaptureBox.Dock = DockStyle.Fill;
            CaptureBox.Location = new Point(3, 60);
            CaptureBox.Margin = new Padding(2);
            CaptureBox.Name = "CaptureBox";
            CaptureBox.Size = new Size(654, 352);
            CaptureBox.SizeMode = PictureBoxSizeMode.Zoom;
            CaptureBox.TabIndex = 0;
            CaptureBox.TabStop = false;
            // 
            // groupBox1
            // 
            tableLayoutPanel1.SetColumnSpan(groupBox1, 2);
            groupBox1.Controls.Add(WebCamList);
            groupBox1.Controls.Add(BtnStartCamera);
            groupBox1.Controls.Add(BtnCapture);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(4, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(851, 50);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // WebCamList
            // 
            WebCamList.FormattingEnabled = true;
            WebCamList.Location = new Point(7, 19);
            WebCamList.Margin = new Padding(2);
            WebCamList.Name = "WebCamList";
            WebCamList.Size = new Size(217, 23);
            WebCamList.TabIndex = 0;
            // 
            // BtnStartCamera
            // 
            BtnStartCamera.Location = new Point(245, 16);
            BtnStartCamera.Margin = new Padding(2);
            BtnStartCamera.Name = "BtnStartCamera";
            BtnStartCamera.Size = new Size(83, 26);
            BtnStartCamera.TabIndex = 1;
            BtnStartCamera.Text = "Start";
            BtnStartCamera.UseVisualStyleBackColor = true;
            BtnStartCamera.Click += BtnStartCamera_Click;
            // 
            // BtnCapture
            // 
            BtnCapture.Location = new Point(347, 7);
            BtnCapture.Margin = new Padding(2);
            BtnCapture.Name = "BtnCapture";
            BtnCapture.Size = new Size(104, 44);
            BtnCapture.TabIndex = 3;
            BtnCapture.Text = "Capture";
            BtnCapture.UseVisualStyleBackColor = true;
            BtnCapture.Click += BtnCapture_Click_1;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Location = new Point(663, 61);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(192, 350);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(859, 415);
            Controls.Add(tableLayoutPanel1);
            IsMdiContainer = true;
            Margin = new Padding(2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)CaptureBox).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox CaptureBox;
        private GroupBox groupBox1;
        private ComboBox WebCamList;
        private Button BtnStartCamera;
        private Button BtnCapture;
        private PictureBox pictureBox2;
    }
}