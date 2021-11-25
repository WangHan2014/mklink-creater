
namespace mklink创建硬链接 {
    partial class MainWindow {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            this.filepath_selector = new System.Windows.Forms.FolderBrowserDialog();
            this.source_address_group = new System.Windows.Forms.GroupBox();
            this.source_address_tips = new System.Windows.Forms.Label();
            this.source_address_serach = new System.Windows.Forms.Button();
            this.source_address_preview = new System.Windows.Forms.TextBox();
            this.destination_address_group = new System.Windows.Forms.GroupBox();
            this.destination_address_name_tips = new System.Windows.Forms.Label();
            this.destination_address_folder = new System.Windows.Forms.TextBox();
            this.destination_address_tips = new System.Windows.Forms.Label();
            this.destination_address_search = new System.Windows.Forms.Button();
            this.destination_address_preview = new System.Windows.Forms.TextBox();
            this.command_preview_tips = new System.Windows.Forms.Label();
            this.command_preview = new System.Windows.Forms.TextBox();
            this.toMklink = new System.Windows.Forms.Button();
            this.source_address_group.SuspendLayout();
            this.destination_address_group.SuspendLayout();
            this.SuspendLayout();
            // 
            // source_address_group
            // 
            this.source_address_group.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.source_address_group.BackColor = System.Drawing.SystemColors.Control;
            this.source_address_group.Controls.Add(this.source_address_tips);
            this.source_address_group.Controls.Add(this.source_address_serach);
            this.source_address_group.Controls.Add(this.source_address_preview);
            this.source_address_group.Location = new System.Drawing.Point(12, 12);
            this.source_address_group.Name = "source_address_group";
            this.source_address_group.Size = new System.Drawing.Size(435, 72);
            this.source_address_group.TabIndex = 0;
            this.source_address_group.TabStop = false;
            this.source_address_group.Text = "源路径";
            // 
            // source_address_tips
            // 
            this.source_address_tips.AutoSize = true;
            this.source_address_tips.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.source_address_tips.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.source_address_tips.Location = new System.Drawing.Point(6, 48);
            this.source_address_tips.Margin = new System.Windows.Forms.Padding(3);
            this.source_address_tips.Name = "source_address_tips";
            this.source_address_tips.Size = new System.Drawing.Size(189, 14);
            this.source_address_tips.TabIndex = 2;
            this.source_address_tips.Text = "选择想要链接的源文件夹路径";
            // 
            // source_address_serach
            // 
            this.source_address_serach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.source_address_serach.Location = new System.Drawing.Point(354, 19);
            this.source_address_serach.Name = "source_address_serach";
            this.source_address_serach.Size = new System.Drawing.Size(75, 23);
            this.source_address_serach.TabIndex = 1;
            this.source_address_serach.Text = "浏览";
            this.source_address_serach.UseVisualStyleBackColor = true;
            this.source_address_serach.Click += new System.EventHandler(this.source_address_serach_Click);
            // 
            // source_address_preview
            // 
            this.source_address_preview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.source_address_preview.Enabled = false;
            this.source_address_preview.Location = new System.Drawing.Point(6, 21);
            this.source_address_preview.Name = "source_address_preview";
            this.source_address_preview.Size = new System.Drawing.Size(341, 21);
            this.source_address_preview.TabIndex = 0;
            this.source_address_preview.TextChanged += new System.EventHandler(this.source_address_preview_TextChanged);
            // 
            // destination_address_group
            // 
            this.destination_address_group.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.destination_address_group.Controls.Add(this.destination_address_name_tips);
            this.destination_address_group.Controls.Add(this.destination_address_folder);
            this.destination_address_group.Controls.Add(this.destination_address_tips);
            this.destination_address_group.Controls.Add(this.destination_address_search);
            this.destination_address_group.Controls.Add(this.destination_address_preview);
            this.destination_address_group.Location = new System.Drawing.Point(12, 90);
            this.destination_address_group.Name = "destination_address_group";
            this.destination_address_group.Size = new System.Drawing.Size(435, 98);
            this.destination_address_group.TabIndex = 1;
            this.destination_address_group.TabStop = false;
            this.destination_address_group.Text = "目标路径";
            // 
            // destination_address_name_tips
            // 
            this.destination_address_name_tips.AutoSize = true;
            this.destination_address_name_tips.Font = new System.Drawing.Font("宋体", 10.5F);
            this.destination_address_name_tips.Location = new System.Drawing.Point(6, 50);
            this.destination_address_name_tips.Name = "destination_address_name_tips";
            this.destination_address_name_tips.Size = new System.Drawing.Size(133, 14);
            this.destination_address_name_tips.TabIndex = 4;
            this.destination_address_name_tips.Text = "生成的文件夹名称：";
            // 
            // destination_address_folder
            // 
            this.destination_address_folder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.destination_address_folder.Location = new System.Drawing.Point(145, 47);
            this.destination_address_folder.Name = "destination_address_folder";
            this.destination_address_folder.Size = new System.Drawing.Size(283, 21);
            this.destination_address_folder.TabIndex = 3;
            this.destination_address_folder.TextChanged += new System.EventHandler(this.destination_address_folder_TextChanged);
            // 
            // destination_address_tips
            // 
            this.destination_address_tips.AutoSize = true;
            this.destination_address_tips.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.destination_address_tips.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.destination_address_tips.Location = new System.Drawing.Point(6, 74);
            this.destination_address_tips.Margin = new System.Windows.Forms.Padding(3);
            this.destination_address_tips.Name = "destination_address_tips";
            this.destination_address_tips.Size = new System.Drawing.Size(203, 14);
            this.destination_address_tips.TabIndex = 3;
            this.destination_address_tips.Text = "选择想要链接的目标文件夹路径";
            // 
            // destination_address_search
            // 
            this.destination_address_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.destination_address_search.Location = new System.Drawing.Point(354, 18);
            this.destination_address_search.Name = "destination_address_search";
            this.destination_address_search.Size = new System.Drawing.Size(75, 23);
            this.destination_address_search.TabIndex = 2;
            this.destination_address_search.Text = "浏览";
            this.destination_address_search.UseVisualStyleBackColor = true;
            this.destination_address_search.Click += new System.EventHandler(this.destination_address_search_Click);
            // 
            // destination_address_preview
            // 
            this.destination_address_preview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.destination_address_preview.Enabled = false;
            this.destination_address_preview.Location = new System.Drawing.Point(7, 20);
            this.destination_address_preview.Name = "destination_address_preview";
            this.destination_address_preview.Size = new System.Drawing.Size(341, 21);
            this.destination_address_preview.TabIndex = 2;
            this.destination_address_preview.TextChanged += new System.EventHandler(this.destination_address_preview_TextChanged);
            // 
            // command_preview_tips
            // 
            this.command_preview_tips.AutoSize = true;
            this.command_preview_tips.Location = new System.Drawing.Point(19, 191);
            this.command_preview_tips.Name = "command_preview_tips";
            this.command_preview_tips.Size = new System.Drawing.Size(383, 12);
            this.command_preview_tips.TabIndex = 1;
            this.command_preview_tips.Text = "命令生成预览：(如果你看不懂请不要修改，或者手动在此自定义命令）";
            // 
            // command_preview
            // 
            this.command_preview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.command_preview.Location = new System.Drawing.Point(18, 206);
            this.command_preview.Name = "command_preview";
            this.command_preview.Size = new System.Drawing.Size(422, 21);
            this.command_preview.TabIndex = 4;
            // 
            // toMklink
            // 
            this.toMklink.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toMklink.ForeColor = System.Drawing.Color.Red;
            this.toMklink.Location = new System.Drawing.Point(18, 234);
            this.toMklink.Name = "toMklink";
            this.toMklink.Size = new System.Drawing.Size(127, 82);
            this.toMklink.TabIndex = 4;
            this.toMklink.Text = "开始";
            this.toMklink.UseVisualStyleBackColor = true;
            this.toMklink.Click += new System.EventHandler(this.toMklink_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(459, 333);
            this.Controls.Add(this.toMklink);
            this.Controls.Add(this.command_preview);
            this.Controls.Add(this.command_preview_tips);
            this.Controls.Add(this.destination_address_group);
            this.Controls.Add(this.source_address_group);
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mklink创建硬链接";
            this.source_address_group.ResumeLayout(false);
            this.source_address_group.PerformLayout();
            this.destination_address_group.ResumeLayout(false);
            this.destination_address_group.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog filepath_selector;
        private System.Windows.Forms.GroupBox source_address_group;
        private System.Windows.Forms.GroupBox destination_address_group;
        private System.Windows.Forms.TextBox source_address_preview;
        private System.Windows.Forms.Button source_address_serach;
        private System.Windows.Forms.Button destination_address_search;
        private System.Windows.Forms.TextBox destination_address_preview;
        private System.Windows.Forms.Label source_address_tips;
        private System.Windows.Forms.Label destination_address_tips;
        private System.Windows.Forms.Label command_preview_tips;
        private System.Windows.Forms.TextBox command_preview;
        private System.Windows.Forms.Button toMklink;
        private System.Windows.Forms.TextBox destination_address_folder;
        private System.Windows.Forms.Label destination_address_name_tips;
    }
}

