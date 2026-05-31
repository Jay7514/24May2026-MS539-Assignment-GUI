namespace MS539_Landrau_14May26_Space_Cowboys_and_Alien_Thugs_RPG
{
    partial class FrmStart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStart));
            lblStats = new Label();
            lblStory = new Label();
            cmbLocations = new ComboBox();
            btnExplore = new Button();
            SuspendLayout();
            // 
            // lblStats
            // 
            lblStats.BackColor = SystemColors.ActiveCaptionText;
            lblStats.Font = new Font("Segoe UI Symbol", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStats.ForeColor = Color.Indigo;
            lblStats.Location = new Point(75, 42);
            lblStats.Margin = new Padding(6);
            lblStats.MaximumSize = new Size(120, 120);
            lblStats.Name = "lblStats";
            lblStats.Size = new Size(120, 37);
            lblStats.TabIndex = 0;
            lblStats.Text = "Stats";
            lblStats.Click += lblStats_Click;
            // 
            // lblStory
            // 
            lblStory.AutoSize = true;
            lblStory.BackColor = SystemColors.Desktop;
            lblStory.Font = new Font("Rockwell", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStory.ForeColor = Color.Indigo;
            lblStory.Location = new Point(75, 530);
            lblStory.Name = "lblStory";
            lblStory.Size = new Size(102, 25);
            lblStory.TabIndex = 1;
            lblStory.Text = "Storyline";
            lblStory.Click += lblStory_Click;
            // 
            // cmbLocations
            // 
            cmbLocations.BackColor = SystemColors.MenuHighlight;
            cmbLocations.FormattingEnabled = true;
            cmbLocations.Location = new Point(751, 42);
            cmbLocations.Name = "cmbLocations";
            cmbLocations.Size = new Size(244, 25);
            cmbLocations.TabIndex = 2;
            cmbLocations.SelectedIndexChanged += cmbLocations_SelectedIndexChanged;
            // 
            // btnExplore
            // 
            btnExplore.BackColor = SystemColors.GradientActiveCaption;
            btnExplore.Location = new Point(751, 288);
            btnExplore.Name = "btnExplore";
            btnExplore.Size = new Size(195, 60);
            btnExplore.TabIndex = 3;
            btnExplore.Text = "Explore";
            btnExplore.UseVisualStyleBackColor = false;
            btnExplore.Click += btnExplore_Click;
            // 
            // FrmStart
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1056, 637);
            Controls.Add(btnExplore);
            Controls.Add(cmbLocations);
            Controls.Add(lblStory);
            Controls.Add(lblStats);
            Name = "FrmStart";
            Text = "Space RPG";
            Load += FrmStart_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStats;
        private Label lblStory;
        private ComboBox cmbLocations;
        private Button btnExplore;
    }
}
