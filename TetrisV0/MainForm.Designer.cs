namespace TetrisV0
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.picturebox_mainfield = new System.Windows.Forms.PictureBox();
            this.button_debug1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_mainfield)).BeginInit();
            this.SuspendLayout();
            // 
            // picturebox_mainfield
            // 
            this.picturebox_mainfield.Location = new System.Drawing.Point(52, 12);
            this.picturebox_mainfield.Name = "picturebox_mainfield";
            this.picturebox_mainfield.Size = new System.Drawing.Size(451, 751);
            this.picturebox_mainfield.TabIndex = 0;
            this.picturebox_mainfield.TabStop = false;
            // 
            // button_debug1
            // 
            this.button_debug1.Location = new System.Drawing.Point(532, 12);
            this.button_debug1.Name = "button_debug1";
            this.button_debug1.Size = new System.Drawing.Size(75, 23);
            this.button_debug1.TabIndex = 1;
            this.button_debug1.Text = "button1";
            this.button_debug1.UseVisualStyleBackColor = true;
            this.button_debug1.Click += new System.EventHandler(this.button_debug1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 809);
            this.Controls.Add(this.button_debug1);
            this.Controls.Add(this.picturebox_mainfield);
            this.DoubleBuffered = true;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_mainfield)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picturebox_mainfield;
        private System.Windows.Forms.Button button_debug1;
    }
}

