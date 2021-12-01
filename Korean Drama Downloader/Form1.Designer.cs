
namespace Korean_Drama_Downloader
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.websiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.youtubeChannelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.telegramChannelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_SearchUI = new System.Windows.Forms.Panel();
            this.listView_Search_Results = new System.Windows.Forms.ListView();
            this.button_Search = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_Search_Query = new System.Windows.Forms.TextBox();
            this.Panel_Episodes_List = new System.Windows.Forms.Panel();
            this.listView_Episodes = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Back = new System.Windows.Forms.Button();
            this.label_Selected_Drama_Title = new System.Windows.Forms.Label();
            this.PicBox_Selected_Drama = new System.Windows.Forms.PictureBox();
            this.donationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paypalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cryptoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel_SearchUI.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Panel_Episodes_List.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_Selected_Drama)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.donationsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(944, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.websiteToolStripMenuItem,
            this.youtubeChannelToolStripMenuItem,
            this.telegramChannelToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // websiteToolStripMenuItem
            // 
            this.websiteToolStripMenuItem.Name = "websiteToolStripMenuItem";
            this.websiteToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.websiteToolStripMenuItem.Text = "Website";
            this.websiteToolStripMenuItem.Click += new System.EventHandler(this.websiteToolStripMenuItem_Click);
            // 
            // youtubeChannelToolStripMenuItem
            // 
            this.youtubeChannelToolStripMenuItem.Name = "youtubeChannelToolStripMenuItem";
            this.youtubeChannelToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.youtubeChannelToolStripMenuItem.Text = "Youtube Channel";
            this.youtubeChannelToolStripMenuItem.Click += new System.EventHandler(this.youtubeChannelToolStripMenuItem_Click);
            // 
            // telegramChannelToolStripMenuItem
            // 
            this.telegramChannelToolStripMenuItem.Name = "telegramChannelToolStripMenuItem";
            this.telegramChannelToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.telegramChannelToolStripMenuItem.Text = "Telegram Channel";
            this.telegramChannelToolStripMenuItem.Click += new System.EventHandler(this.telegramChannelToolStripMenuItem_Click);
            // 
            // panel_SearchUI
            // 
            this.panel_SearchUI.Controls.Add(this.listView_Search_Results);
            this.panel_SearchUI.Controls.Add(this.button_Search);
            this.panel_SearchUI.Controls.Add(this.groupBox1);
            this.panel_SearchUI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_SearchUI.Location = new System.Drawing.Point(0, 28);
            this.panel_SearchUI.Name = "panel_SearchUI";
            this.panel_SearchUI.Size = new System.Drawing.Size(944, 656);
            this.panel_SearchUI.TabIndex = 1;
            // 
            // listView_Search_Results
            // 
            this.listView_Search_Results.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView_Search_Results.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_Search_Results.HideSelection = false;
            this.listView_Search_Results.Location = new System.Drawing.Point(12, 98);
            this.listView_Search_Results.Name = "listView_Search_Results";
            this.listView_Search_Results.Size = new System.Drawing.Size(917, 546);
            this.listView_Search_Results.TabIndex = 2;
            this.listView_Search_Results.UseCompatibleStateImageBehavior = false;
            this.listView_Search_Results.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView_Search_Results_MouseClick);
            // 
            // button_Search
            // 
            this.button_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Search.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Search.Location = new System.Drawing.Point(806, 20);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(123, 69);
            this.button_Search.TabIndex = 1;
            this.button_Search.Text = "Search";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.textBox_Search_Query);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(761, 78);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Drama To Search";
            // 
            // textBox_Search_Query
            // 
            this.textBox_Search_Query.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Search_Query.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Search_Query.Location = new System.Drawing.Point(10, 31);
            this.textBox_Search_Query.Name = "textBox_Search_Query";
            this.textBox_Search_Query.Size = new System.Drawing.Size(695, 30);
            this.textBox_Search_Query.TabIndex = 0;
            // 
            // Panel_Episodes_List
            // 
            this.Panel_Episodes_List.Controls.Add(this.listView_Episodes);
            this.Panel_Episodes_List.Controls.Add(this.label1);
            this.Panel_Episodes_List.Controls.Add(this.button_Back);
            this.Panel_Episodes_List.Controls.Add(this.label_Selected_Drama_Title);
            this.Panel_Episodes_List.Controls.Add(this.PicBox_Selected_Drama);
            this.Panel_Episodes_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Episodes_List.Location = new System.Drawing.Point(0, 28);
            this.Panel_Episodes_List.Name = "Panel_Episodes_List";
            this.Panel_Episodes_List.Size = new System.Drawing.Size(944, 656);
            this.Panel_Episodes_List.TabIndex = 3;
            this.Panel_Episodes_List.Visible = false;
            // 
            // listView_Episodes
            // 
            this.listView_Episodes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView_Episodes.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_Episodes.HideSelection = false;
            this.listView_Episodes.Location = new System.Drawing.Point(12, 316);
            this.listView_Episodes.Name = "listView_Episodes";
            this.listView_Episodes.Size = new System.Drawing.Size(917, 324);
            this.listView_Episodes.TabIndex = 7;
            this.listView_Episodes.UseCompatibleStateImageBehavior = false;
            this.listView_Episodes.View = System.Windows.Forms.View.List;
            this.listView_Episodes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView_Episodes_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Episodes List";
            // 
            // button_Back
            // 
            this.button_Back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Back.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Back.Location = new System.Drawing.Point(792, 14);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(137, 58);
            this.button_Back.TabIndex = 5;
            this.button_Back.Text = "Go Back";
            this.button_Back.UseVisualStyleBackColor = true;
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // label_Selected_Drama_Title
            // 
            this.label_Selected_Drama_Title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Selected_Drama_Title.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Selected_Drama_Title.Location = new System.Drawing.Point(277, 20);
            this.label_Selected_Drama_Title.Name = "label_Selected_Drama_Title";
            this.label_Selected_Drama_Title.Size = new System.Drawing.Size(486, 186);
            this.label_Selected_Drama_Title.TabIndex = 2;
            // 
            // PicBox_Selected_Drama
            // 
            this.PicBox_Selected_Drama.Location = new System.Drawing.Point(18, 11);
            this.PicBox_Selected_Drama.Name = "PicBox_Selected_Drama";
            this.PicBox_Selected_Drama.Size = new System.Drawing.Size(222, 258);
            this.PicBox_Selected_Drama.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBox_Selected_Drama.TabIndex = 0;
            this.PicBox_Selected_Drama.TabStop = false;
            // 
            // donationsToolStripMenuItem
            // 
            this.donationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paypalToolStripMenuItem,
            this.cryptoToolStripMenuItem});
            this.donationsToolStripMenuItem.Name = "donationsToolStripMenuItem";
            this.donationsToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.donationsToolStripMenuItem.Text = "Donations";
            this.donationsToolStripMenuItem.Click += new System.EventHandler(this.donationsToolStripMenuItem_Click);
            // 
            // paypalToolStripMenuItem
            // 
            this.paypalToolStripMenuItem.Name = "paypalToolStripMenuItem";
            this.paypalToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.paypalToolStripMenuItem.Text = "Paypal";
            this.paypalToolStripMenuItem.Click += new System.EventHandler(this.paypalToolStripMenuItem_Click);
            // 
            // cryptoToolStripMenuItem
            // 
            this.cryptoToolStripMenuItem.Name = "cryptoToolStripMenuItem";
            this.cryptoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cryptoToolStripMenuItem.Text = "Crypto";
            this.cryptoToolStripMenuItem.Click += new System.EventHandler(this.cryptoToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 684);
            this.Controls.Add(this.panel_SearchUI);
            this.Controls.Add(this.Panel_Episodes_List);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Korean Drama Downloader";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel_SearchUI.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Panel_Episodes_List.ResumeLayout(false);
            this.Panel_Episodes_List.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_Selected_Drama)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Panel panel_SearchUI;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_Search_Query;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.ListView listView_Search_Results;
        private System.Windows.Forms.Panel Panel_Episodes_List;
        private System.Windows.Forms.PictureBox PicBox_Selected_Drama;
        private System.Windows.Forms.Label label_Selected_Drama_Title;
        private System.Windows.Forms.Button button_Back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView_Episodes;
        private System.Windows.Forms.ToolStripMenuItem websiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem youtubeChannelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem telegramChannelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem donationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paypalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cryptoToolStripMenuItem;
    }
}

