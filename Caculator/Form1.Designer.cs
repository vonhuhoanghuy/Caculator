namespace Caculator
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
            txtBK = new TextBox();
            txtResult = new TextBox();
            btS = new Button();
            btCV = new Button();
            btClose = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblThongbao = new Label();
            SuspendLayout();
            // 
            // txtBK
            // 
            txtBK.Location = new Point(291, 141);
            txtBK.Margin = new Padding(4);
            txtBK.Name = "txtBK";
            txtBK.Size = new Size(170, 34);
            txtBK.TabIndex = 0;
            txtBK.TextChanged += textBox1_TextChanged;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(291, 204);
            txtResult.Margin = new Padding(4);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(170, 34);
            txtResult.TabIndex = 1;
            txtResult.TextChanged += textBox2_TextChanged;
            // 
            // btS
            // 
            btS.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btS.ForeColor = Color.IndianRed;
            btS.Location = new Point(120, 283);
            btS.Margin = new Padding(4);
            btS.Name = "btS";
            btS.Size = new Size(106, 41);
            btS.TabIndex = 1;
            btS.Text = "Diện tích ";
            btS.UseVisualStyleBackColor = true;
            btS.Click += button1_Click;
            // 
            // btCV
            // 
            btCV.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btCV.ForeColor = Color.IndianRed;
            btCV.Location = new Point(291, 283);
            btCV.Margin = new Padding(4);
            btCV.Name = "btCV";
            btCV.Size = new Size(93, 41);
            btCV.TabIndex = 2;
            btCV.Text = "Chu vi ";
            btCV.UseVisualStyleBackColor = true;
            btCV.Click += button2_Click;
            // 
            // btClose
            // 
            btClose.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btClose.ForeColor = Color.IndianRed;
            btClose.Location = new Point(441, 283);
            btClose.Margin = new Padding(4);
            btClose.Name = "btClose";
            btClose.Size = new Size(89, 41);
            btClose.TabIndex = 4;
            btClose.Text = "Đóng";
            btClose.UseVisualStyleBackColor = true;
            btClose.Click += btDong_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(120, 141);
            label1.Name = "label1";
            label1.Size = new Size(150, 26);
            label1.TabIndex = 5;
            label1.Text = "Nhập bán kính";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(120, 204);
            label2.Name = "label2";
            label2.Size = new Size(90, 26);
            label2.TabIndex = 6;
            label2.Text = "Kết quả ";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(120, 31);
            label3.Name = "label3";
            label3.Size = new Size(227, 56);
            label3.TabIndex = 7;
            label3.Text = "CHƯƠNG TRÌNH \r\nTÍNH TOÁN ĐƠN GIẢN \r\n";
            // 
            // lblThongbao
            // 
            lblThongbao.AutoSize = true;
            lblThongbao.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblThongbao.ForeColor = Color.Blue;
            lblThongbao.Location = new Point(127, 116);
            lblThongbao.Name = "lblThongbao";
            lblThongbao.Size = new Size(144, 20);
            lblThongbao.TabIndex = 8;
            lblThongbao.Text = "Hãy nhập bán kính";
            lblThongbao.Click += label4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 442);
            Controls.Add(lblThongbao);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btClose);
            Controls.Add(btCV);
            Controls.Add(btS);
            Controls.Add(txtResult);
            Controls.Add(txtBK);
            Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            ForeColor = Color.Black;
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Caculator";
            FormClosing += Form1_FormClosing;
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            Click += Form1_Click;
            DoubleClick += Form1_DoubleClick;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBK;
        private TextBox txtResult;
        private Button btS;
        private Button btCV;
        private Button btClose;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblThongbao;
    }
}