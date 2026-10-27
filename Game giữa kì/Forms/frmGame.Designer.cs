namespace Game_giữa_kì
{
    partial class frmGame
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlTop = new System.Windows.Forms.TableLayoutPanel();
            this.cboLevel = new System.Windows.Forms.ComboBox();
            this.lblFlag = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlBoard = new System.Windows.Forms.Panel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.ColumnCount = 5;
            this.pnlTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnlTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnlTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnlTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnlTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnlTop.Controls.Add(this.cboLevel, 0, 0);
            this.pnlTop.Controls.Add(this.lblFlag, 1, 0);
            this.pnlTop.Controls.Add(this.btnReset, 2, 0);
            this.pnlTop.Controls.Add(this.lblTime, 3, 0);
            this.pnlTop.Controls.Add(this.btnBack, 4, 0);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.RowCount = 1;
            this.pnlTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlTop.Size = new System.Drawing.Size(711, 42);
            this.pnlTop.TabIndex = 0;
            // 
            // cboLevel
            // 
            this.cboLevel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLevel.FormattingEnabled = true;
            this.cboLevel.Items.AddRange(new object[] {
            "Dễ(9x9)",
            "Vừa(16x16)",
            "Khó(16x30)"});
            this.cboLevel.Location = new System.Drawing.Point(17, 9);
            this.cboLevel.Name = "cboLevel";
            this.cboLevel.Size = new System.Drawing.Size(108, 24);
            this.cboLevel.TabIndex = 1;
            // 
            // lblFlag
            // 
            this.lblFlag.AutoSize = true;
            this.lblFlag.BackColor = System.Drawing.Color.Black;
            this.lblFlag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFlag.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlag.ForeColor = System.Drawing.Color.Red;
            this.lblFlag.Location = new System.Drawing.Point(145, 0);
            this.lblFlag.Name = "lblFlag";
            this.lblFlag.Size = new System.Drawing.Size(136, 42);
            this.lblFlag.TabIndex = 2;
            this.lblFlag.Text = "🚩 10";
            this.lblFlag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReset
            // 
            this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI Emoji", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(331, 3);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(48, 36);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "🙂";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.Color.Black;
            this.lblTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Red;
            this.lblTime.Location = new System.Drawing.Point(429, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(136, 42);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "⏱ 000";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBack.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(571, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(136, 36);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // pnlBoard
            // 
            this.pnlBoard.Location = new System.Drawing.Point(0, 78);
            this.pnlBoard.Name = "pnlBoard";
            this.pnlBoard.Size = new System.Drawing.Size(699, 270);
            this.pnlBoard.TabIndex = 1;
            this.pnlBoard.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBoard_Paint_1);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.pnlBoard);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dò Mìn - Minesweeper";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.TableLayoutPanel pnlTop;
        private System.Windows.Forms.ComboBox cboLevel;
        private System.Windows.Forms.Label lblFlag;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel pnlBoard;
        private System.Windows.Forms.Timer timer;
    }
}