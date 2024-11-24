namespace Demo
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_InitialLog = new System.Windows.Forms.Button();
            this.btn_WriteMsg = new System.Windows.Forms.Button();
            this.btn_OpenLogDir = new System.Windows.Forms.Button();
            this.btn_ClearMsg = new System.Windows.Forms.Button();
            this.rtb_MsgInfo = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btn_InitialLog
            // 
            this.btn_InitialLog.Location = new System.Drawing.Point(12, 12);
            this.btn_InitialLog.Name = "btn_InitialLog";
            this.btn_InitialLog.Size = new System.Drawing.Size(75, 23);
            this.btn_InitialLog.TabIndex = 0;
            this.btn_InitialLog.Text = "Initial";
            this.btn_InitialLog.UseVisualStyleBackColor = true;
            this.btn_InitialLog.Click += new System.EventHandler(this.btn_InitialLog_Click);
            // 
            // btn_WriteMsg
            // 
            this.btn_WriteMsg.Location = new System.Drawing.Point(394, 199);
            this.btn_WriteMsg.Name = "btn_WriteMsg";
            this.btn_WriteMsg.Size = new System.Drawing.Size(75, 52);
            this.btn_WriteMsg.TabIndex = 1;
            this.btn_WriteMsg.Text = "Write";
            this.btn_WriteMsg.UseVisualStyleBackColor = true;
            this.btn_WriteMsg.Click += new System.EventHandler(this.btn_WriteMsg_Click);
            // 
            // btn_OpenLogDir
            // 
            this.btn_OpenLogDir.Location = new System.Drawing.Point(93, 12);
            this.btn_OpenLogDir.Name = "btn_OpenLogDir";
            this.btn_OpenLogDir.Size = new System.Drawing.Size(107, 23);
            this.btn_OpenLogDir.TabIndex = 2;
            this.btn_OpenLogDir.Text = "Open Log Dir";
            this.btn_OpenLogDir.UseVisualStyleBackColor = true;
            this.btn_OpenLogDir.Click += new System.EventHandler(this.btn_OpenLogDir_Click);
            // 
            // btn_ClearMsg
            // 
            this.btn_ClearMsg.Location = new System.Drawing.Point(394, 12);
            this.btn_ClearMsg.Name = "btn_ClearMsg";
            this.btn_ClearMsg.Size = new System.Drawing.Size(75, 23);
            this.btn_ClearMsg.TabIndex = 3;
            this.btn_ClearMsg.Text = "Clear";
            this.btn_ClearMsg.UseVisualStyleBackColor = true;
            this.btn_ClearMsg.Click += new System.EventHandler(this.btn_ClearMsg_Click);
            // 
            // rtb_MsgInfo
            // 
            this.rtb_MsgInfo.BackColor = System.Drawing.SystemColors.InfoText;
            this.rtb_MsgInfo.Location = new System.Drawing.Point(12, 41);
            this.rtb_MsgInfo.Name = "rtb_MsgInfo";
            this.rtb_MsgInfo.Size = new System.Drawing.Size(457, 152);
            this.rtb_MsgInfo.TabIndex = 5;
            this.rtb_MsgInfo.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 264);
            this.Controls.Add(this.rtb_MsgInfo);
            this.Controls.Add(this.btn_ClearMsg);
            this.Controls.Add(this.btn_OpenLogDir);
            this.Controls.Add(this.btn_WriteMsg);
            this.Controls.Add(this.btn_InitialLog);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_InitialLog;
        private System.Windows.Forms.Button btn_WriteMsg;
        private System.Windows.Forms.Button btn_OpenLogDir;
        private System.Windows.Forms.Button btn_ClearMsg;
        private System.Windows.Forms.RichTextBox rtb_MsgInfo;
    }
}

